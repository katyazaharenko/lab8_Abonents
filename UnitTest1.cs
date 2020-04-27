using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abonents_lab8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        List<string> columnsList = new List<string>{
                "Фамилия",
                "Номер_договора",
                "Район",
                "Адрес",
                "Телефон",
                "Дата_договора",
                "Оплата_установки",
                "Абонентская_плата",
                "Последний_платеж"};
        string actual = "";
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "XmlException";
            try
            {
                XDocument xdoc = XDocument.Load("test1.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string expected = "XmlException";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test2.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod4()
        {
            string expected = "";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test3.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod5()
        {
            string expected = "XmlException";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test4.xml");
                if (xdoc.Element("Subscribers") == null) {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod6()
        {
            string expected = "XmlException";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test5.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "FileNotFoundException";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("adad.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod8()
        {
            string expected = "NullReferenceException";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test9.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
                foreach (var i in subscribers)
                {
                    Console.WriteLine(i.Name+ i.Contract + i.District + i.Address + i.Telephone,
                        i.ContractDate + i.EquipmentPayment + i.SubscriptionFee + i.LastPayment);
                }
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod9()
        {
            string expected = "NullReferenceException";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test10.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
                foreach (var i in subscribers)
                {
                    Console.WriteLine(i.Name + i.Contract + i.District + i.Address + i.Telephone,
                        i.ContractDate + i.EquipmentPayment + i.SubscriptionFee + i.LastPayment);
                }
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
        [TestMethod]
        public void TestMethod10()
        {
            string expected = "";
            try
            {
                actual = "";
                XDocument xdoc = XDocument.Load("test6.xml");
                if (xdoc.Element("Subscribers") == null)
                {
                    throw new System.Xml.XmlException();
                }
                var subscribers = from subscriber in xdoc.Descendants("Subscriber")
                                  select new
                                  {
                                      Name = subscriber.Element(columnsList[0]).Value,
                                      Contract = subscriber.Element(columnsList[1]).Value,
                                      District = subscriber.Element(columnsList[2]).Value,
                                      Address = subscriber.Element(columnsList[3]).Value,
                                      Telephone = subscriber.Element(columnsList[4]).Value,
                                      ContractDate = subscriber.Element(columnsList[5]).Value,
                                      EquipmentPayment = subscriber.Element(columnsList[6]).Value,
                                      SubscriptionFee = subscriber.Element(columnsList[7]).Value,
                                      LastPayment = subscriber.Element(columnsList[8]).Value

                                  };
                
            }
            catch (NullReferenceException)
            {
                actual = "NullReferenceException";
            }
            catch (FileNotFoundException)
            {
                actual = "FileNotFoundException";
            }
            catch (System.Xml.XmlException)
            {
                actual = "XmlException";
            }
            catch (Exception ex)
            {
                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
    }
}
