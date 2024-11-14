using System;
using System.Collections.Generic;
namespace POO.Documents{
    public class Document{
        #region Private Properties
        private int _documentId;
        private string _documentName;
        private string _documentDescription;
        private DateTime _documentDate;
        private DocumentType _documentType;
        private bool _isSigned;
        // private string _signature;
        private List<Document> _documents = new List<Document>();
        #endregion
        #region Public Properties
        public int DocumentId{
            get { return _documentId; }
            set { _documentId = value; }
        }
        public string DocumentName{
            get { return _documentName; }
            set { _documentName = value; }
        }
        public string DocumentDescription{
            get { return _documentDescription; }
            set { _documentDescription = value; }
        }
        public DateTime DocumentDate{
            get { return _documentDate; }
            set { _documentDate = value; }
        }
        public DocumentType DocumentType{
            get { return _documentType; }
            set { _documentType = value; }
        }
        public bool IsSigned{
            get { return _isSigned; }
            set { _isSigned = value; }
        }
        #endregion
        #region Constructors
        public Document(int documentId, string documentName, string documentDescription, DateTime documentDate, DocumentType documentType){
            _documentId = documentId;
            _documentName = documentName;
            _documentDescription = documentDescription;
            _documentDate = documentDate;
            _documentType = documentType;
            _isSigned = IsSigned;
        }
        #endregion
        #region Methods
        public void AddDocument(Document document){
            _documents.Add(document);
        }
        public void RemoveDocument(Document document){
            _documents.Remove(document);
        }
        public void SignDocument(){
            _isSigned = true;
            // _signature = "Signed by: " + User.UserName; // Using User class to get the signed user's name
        }
        #endregion
    }
    public enum DocumentType{
        BriefingReport,
        Budget,
        ProjectReport,
        MeetingSummary,
        Other 
    }
}