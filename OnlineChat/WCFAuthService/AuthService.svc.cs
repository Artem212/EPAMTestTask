using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace WCFAuthService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "AuthService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы AuthService.svc или AuthService.svc.cs в обозревателе решений и начните отладку.
    public class AuthService : IAuthService
    {

        private string LoginFilePath = @"C:\Users\User\source\repos\OnlineChat\WCFAuthService\ServiceData\Logins.xml";
        public string GetLogin(int cookieId)
        {
            XDocument doc = XDocument.Load(LoginFilePath);
            string name = (from nickname in doc.Root.Elements("nickname")
                           where nickname.Element("cookieID").Value == cookieId.ToString()
                           select nickname.Element("name").Value).First();
            return name;
        }
        public int SaveLogin(string login)
        {
            XDocument doc = XDocument.Load(LoginFilePath);
            int id = (doc.Root.Elements("nickname")
                .Max(x => (int)x.Element("cookieID")));
            id += 1;
            XElement root = doc.Element("root");
            root.Add(new XElement("nickname",
                       new XElement("cookieID", id.ToString()),
                       new XElement("name", login)));
            doc.Save(LoginFilePath);
            return id;
        }
    }
}
