//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sparky
//{
//    [TestFixture]
//    public class CustomerXUnitTests
//    {
//        private Customer customer;
//        [SetUp]
//        public void SetUp()
//        {
//            customer = new Customer();
//        }

//        [Test]
//        public void CombineName_InputFirstAndLastName_ReturnFullName()
//        {
//            //arrange
//            //var customer = new Customer();

//            //act
//            customer.CombineNames("Belma", "Hanna");

//            //assert
//            Assert.Multiple(() =>
//            {
//                Assert.AreEqual(customer.GreetMessage, "Hello, Belma Hanna");
//                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Belma Hanna"));
//                Assert.That(customer.GreetMessage, Does.Contain(","));
//                Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
//                Assert.That(customer.GreetMessage, Does.EndWith("Hanna"));
//                Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
//            });

            
//        }

//        [Test]
//        public void GreetMessage_NotGreeted_ReturnNull()
//        {
//           //arrange
//            //var customer = new Customer();

//            //act
//            //prazan jer samo zelimo vidjeti rezultat, ne saljemo parametre

//            //assert
//            Assert.IsNull(customer.GreetMessage);
//        }

//        [Test]
//        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
//        {
//            int result = customer.Discount;
//            Assert.That(result, Is.InRange(10, 25));


//        }

//        [Test]
//        public void GreetMesage_GreetedWithoutLastName_ReturnsNotNull()
//        {
//            customer.CombineNames("Belma", "");

//            Assert.IsNotNull(customer.GreetMessage);
//            Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
//        }
        

//        [Test]
//        public void GreetChecker_EmptyFirstName_ThrowsException()
//        {
//            var exceptionDetails = Assert.Throws<ArgumentException>(()=> customer.CombineNames("", "Spark"));
//            Assert.AreEqual("Empty first name.", exceptionDetails.Message);

//            Assert.That(() => customer.CombineNames("", "hanna"), Throws.ArgumentException.With.Message.EqualTo("Empty first name."));

//            //
//            Assert.Throws<ArgumentException>(() => customer.CombineNames("", "Spark"));
//            Assert.AreEqual("Empty first name.", exceptionDetails.Message);

//            Assert.That(() => customer.CombineNames("", "hanna"), Throws.ArgumentException);
//        }

//        [Test]
//        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
//        {
//            customer.OrderTotal = 10;
//            var result=customer.GetCustomerDetails();

//            Assert.That(result, Is.TypeOf<BasicCustomer>());
//        }
//        [Test]
//        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnBasicCustomer()
//        {
//            customer.OrderTotal = 110;
//            var result = customer.GetCustomerDetails();

//            Assert.That(result, Is.TypeOf<PlatinumCustomer>());
//        }

//    }
//}
