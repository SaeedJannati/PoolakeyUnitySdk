using UnityEngine;
using Poolakey;
using Poolakey.Scripts;
using UnityEngine.UI;

public class PoolakeyExample : MonoBehaviour
{
    public Text ConsoleText;

    private Payment payment;
    void Start()
    {
        Log("Poolakey Plugin Version: " + PluginVersion.VersionString);
        SecurityCheck securityCheck = SecurityCheck.Disable();
        PaymentConfiguration paymentConfiguration = new PaymentConfiguration(securityCheck);
        payment = new Payment(paymentConfiguration);
    }

    public void Connect()
    {
        payment.Connect();
    }

    public void PurchaseProduct()
    {
        payment.purchaseProduct("test");
    }
    public void SubscribeProduct()
    {
        payment.subscribeProduct("test");
    }

    public void Log(string message)
    {
        ConsoleText.text += message + "\n";
    }
}
