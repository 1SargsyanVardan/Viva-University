using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SmsExtension
    {
        public static IEnumerable<Sms> FilterBySender(this IEnumerable<Sms> smsMessages, string sender)
        {
            return smsMessages.Where(sms => sms.Sender.Equals(sender, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Sms> FilterByKeyword(this IEnumerable<Sms> smsMessages, string keyword)
        {
            return smsMessages.Where(sms => sms.SmsContent.Contains(keyword, StringComparison.OrdinalIgnoreCase));//?
        }
    }
    public class Sms
    {
        string smsId;
        string sender;
        string smsContent;
        public Sms()
        {
            smsId = "Default ID";
            sender = "Viva-MTS";
            smsContent = "Barev hargeli hachaxord";
        }
        public Sms(string smsId, string sender, string smsContent)
        {
            this.smsId = smsId;
            this.sender = sender;
            this.smsContent = smsContent;
        }
        public void AllData()
        {
            Console.WriteLine($"{this.SmsId} | Sender {this.Sender} | Message {this.SmsContent}");
        }
        public string SmsId
        {
            get { return smsId; }
        }
        public string Sender
        {
            get { return sender; }
        }
        public string SmsContent
        {
            get { return smsContent; }
        }
    }
}
