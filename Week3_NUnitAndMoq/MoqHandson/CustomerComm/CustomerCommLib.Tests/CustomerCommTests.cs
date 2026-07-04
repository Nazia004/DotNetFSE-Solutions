using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerCommLib.Tests;

public class CustomerCommTests
{
    [Test]
    public void SendMailToCustomer_ShouldReturnTrue_WhenMailSent()
    {
        // Arrange
        var mockMailSender = new Mock<IMailSender>();

        var customer = new Customer
        {
            CustomerId = 1,
            CustomerName = "Nazia",
            CustomerAddress = "Bhubaneswar",
            CustomerEmail = "nazia@gmail.com"
        };

        mockMailSender
            .Setup(x => x.SendMail(customer))
            .Returns(true);

        var customerComm = new CustomerComm(mockMailSender.Object);

        // Act
        bool result = customerComm.SendMailToCustomer(customer);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void SendMailToCustomer_ShouldReturnFalse_WhenMailNotSent()
    {
        // Arrange
        var mockMailSender = new Mock<IMailSender>();

        var customer = new Customer
        {
            CustomerId = 2,
            CustomerName = "Ali",
            CustomerAddress = "Delhi",
            CustomerEmail = "ali@gmail.com"
        };

        mockMailSender
            .Setup(x => x.SendMail(customer))
            .Returns(false);

        var customerComm = new CustomerComm(mockMailSender.Object);

        // Act
        bool result = customerComm.SendMailToCustomer(customer);

        // Assert
        Assert.That(result, Is.False);
    }
}