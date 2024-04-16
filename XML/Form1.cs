using System.Xml;
using System.IO;
using System.Xml.Serialization;
using ServiceReference1;
using System.Xml.Linq;
using XML.Entity;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context.Contextt db = new Context.Contextt();
        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new ServiceReference1.CountryInfoServiceSoapTypeClient(ServiceReference1.CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap12);

            var result = await client.FullCountryInfoAllCountriesAsync();

            var tCountryInfos = result.Body.FullCountryInfoAllCountriesResult;

            CountryInfo countryInfo = new CountryInfo();


            var xmlSerializer = new XmlSerializer(typeof(tCountryInfo[]));
            var writer = new StringWriter();
            xmlSerializer.Serialize(writer, tCountryInfos);
            var xmlcontent=writer.ToString();

            StringReader reader = new StringReader(xmlcontent);
            var tCountries = (tCountryInfo[])xmlSerializer.Deserialize(reader);

            foreach (var item in tCountries)
            {
                countryInfo.sISOCode = item.sISOCode;
                countryInfo.sName = item.sName;
                countryInfo.sCapitalCity = item.sCapitalCity;
                countryInfo.sPhoneCode = item.sPhoneCode;
                countryInfo.sContinentCode = item.sContinentCode;
                countryInfo.sCurrencyISOCode = item.sCurrencyISOCode;
                countryInfo.sCountryFlag = item.sCountryFlag;
                db.CountryInfo.Add(countryInfo);
                db.SaveChanges();
            }


           



            

          /*  foreach (var item in tCountryInfos)
            {

                countryInfo.sISOCode = item.sISOCode;
                countryInfo.sName = item.sName;
                countryInfo.sCapitalCity=item.sCapitalCity;
                countryInfo.sPhoneCode = item.sPhoneCode;
                countryInfo.sContinentCode = item.sContinentCode;
                countryInfo.sCurrencyISOCode = item.sCurrencyISOCode;
                countryInfo.sCountryFlag = item.sCountryFlag;
                db.CountryInfo.Add(countryInfo);
                db.SaveChanges();
                                
            }*/


          

          

               

              

               

               

            



            
            

            


            

            








        }


    }
}