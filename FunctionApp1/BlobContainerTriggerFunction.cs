using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class BlobContainerTriggerFunction
    {
        [FunctionName("BlobContainerTriggerFunction")]
        public static void Run([BlobTrigger("container04032020/{name}", 
            Connection = "DefaultEndpointsProtocol=https;AccountName=storeageaccount04032020;AccountKey=SrJxUF0AQWOP9ICBxQtanr68mn/CRnbu23oKQE1kRILqu/W6FbqZCr7veZGXFlWYRXScyGj7QTMebCgYXcd2dw==;EndpointSuffix=core.windows.net")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
