using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Teste
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]

        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            var student = new Student("Alexandre", "Jareck", "12345678912", "alexandrejareck@gmail.com");

            student.AddSubscription(subscription);
        }
    }
}