using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace ServOdroid.Models
{
    public class Robot
    {
        #region Attributes
        private string _lastName;
        private string _firstMidName;
        private DateTime _enrollmentDate;

        private List<string> _picturePath;
        private string _description;
        private string _videoPath;
        private List<string> _links; 
        private bool _real;
        private string _name;
        private string _surname;
        private string _movment;
        private string _from;
        private string _constructor;
        private string _serie;
        private string _model;
        private string _size;
        private string _color;
        private string _eyes;
        private string _armement;
        private string _equipements;
        private string _affiliation;
        private string _function;
        private string _epoque;
        #endregion

        #region Properties
        public DateTime EnrollmentDate
        {
            get { return _enrollmentDate; }
            set { _enrollmentDate = value; }
        }
        public string FirstMidName
        {
            get { return _firstMidName; }
            set { _firstMidName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public List<string> Links
        {
            get
            {
                if (_links == null) _links = new List<string>(); 
                return _links; 
            }
            set
            {
                if (_links == null) _links = new List<string>(); 
                _links = value; 
            }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string VideoPath
        {
            get { return _videoPath; }
            set { _videoPath = value; }
        }
        public List<string> PicturePath
        {
            get 
            {
                if (_picturePath == null) _picturePath = new List<string>();
                return _picturePath; 
            }
            set
            {
                if (_picturePath == null) _picturePath = new List<string>();
                _picturePath = value; 
            }
        }
        public bool Real
        {
            get { return _real; }
            set { _real = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Movment
        {
            get { return _movment; }
            set { _movment = value; }
        }
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        public string Constructor
        {
            get { return _constructor; }
            set { _constructor = value; }
        }
        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Eyes
        {
            get { return _eyes; }
            set { _eyes = value; }
        }
        public string Armement
        {
            get { return _armement; }
            set { _armement = value; }
        }
        public string Equipements
        {
            get { return _equipements; }
            set { _equipements = value; }
        }
        public string Affiliation
        {
            get { return _affiliation; }
            set { _affiliation = value; }
        }
        public string Function
        {
            get { return _function; }
            set { _function = value; }
        }
        public string Epoque
        {
            get { return _epoque; }
            set { _epoque = value; }
        }
        #endregion

        #region Constructor
        public Robot()
        {

        }
        #endregion

        #region Methods public
        public void LoadInfo(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(filePath);

                    XmlNodeList element = xml.GetElementsByTagName("name");
                    if (element[0].Attributes.GetNamedItem("value") != null) Name = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("surname");
                    if (element[0].Attributes.GetNamedItem("value") != null) Surname = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("real");
                    if (element.Count > 0 && element[0].Attributes.GetNamedItem("value") != null) Real = element[0].Attributes.GetNamedItem("value").Value.Equals("true") ? true : false;

                    element = xml.GetElementsByTagName("movment");
                    if (element[0].Attributes.GetNamedItem("value") != null) Movment = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("movment");
                    if (element[0].Attributes.GetNamedItem("value") != null) Movment = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("from");
                    if (element[0].Attributes.GetNamedItem("value") != null) From = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("constructeur");
                    if (element[0].Attributes.GetNamedItem("value") != null) Constructor = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("serie");
                    if (element[0].Attributes.GetNamedItem("value") != null) Serie = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("modele");
                    if (element[0].Attributes.GetNamedItem("value") != null) Model = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("size");
                    if (element[0].Attributes.GetNamedItem("value") != null) Size = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("color");
                    if (element[0].Attributes.GetNamedItem("value") != null) Color = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("eyes");
                    if (element[0].Attributes.GetNamedItem("value") != null) Eyes = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("armement");
                    if (element[0].Attributes.GetNamedItem("value") != null) Armement = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("equipement");
                    if (element[0].Attributes.GetNamedItem("value") != null) Equipements = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("affiliation");
                    if (element[0].Attributes.GetNamedItem("value") != null) Affiliation = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("function");
                    if (element[0].Attributes.GetNamedItem("value") != null) Function = element[0].Attributes.GetNamedItem("value").Value;

                    element = xml.GetElementsByTagName("epoque");
                    if (element[0].Attributes.GetNamedItem("value") != null) Epoque = element[0].Attributes.GetNamedItem("value").Value;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
        public void LoadDescription(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                this._description = sr.ReadToEnd();
            }
        }
        public void LoadLink(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while(sr.Peek() > 0)
                {
                    this.Links.Add(sr.ReadLine());
                }
            }
        }
        #endregion
    }
}