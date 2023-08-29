using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using Microsoft.Extensions.Options;
using OverPar.Domain.Interfaces.Connectors;
using OverPar.Domain.Settings;

namespace OverPar.Infrastructure
{
    public class FormRecognizorConnector : IFormRecognizorConnector
    {
        private readonly FormReaderSettings _formReaderSettings;
        private AzureKeyCredential _keyCredential;
        private DocumentAnalysisClient _client;

        public FormRecognizorConnector(IOptions<FormReaderSettings> options)
        {
            _formReaderSettings = options.Value;
            _keyCredential = new AzureKeyCredential(_formReaderSettings.Key);
            _client = new DocumentAnalysisClient(new Uri(_formReaderSettings.Endpoint), _keyCredential);
            var client = new DocumentModelAdministrationClient(new Uri(_formReaderSettings.Endpoint), _keyCredential);
        }

        public async Task ProcessScorecardAsync(byte[] imageBytes, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            using var stream = new MemoryStream(imageBytes);
            
            var response = await _client.AnalyzeDocumentAsync(WaitUntil.Completed, "Golf_Scorecard_model", stream, cancellationToken: token);
            var result = response.Value;

            foreach (var document in result.Documents)
            {

            }

        }
    }
}