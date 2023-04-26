using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;


namespace CKC_App_4155.objects
{
    public class Event : ObservableObject
    {
        public int id;
        public string title;
        public string eventDetails;
        public string hostName;
        public string location;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                SetProperty(ref title, value);

            }
        }

        public Event() { }
        public Event(int id, string title, string eventDetails, string hostName, string location)
        {
            this.id = id;
            this.eventDetails = eventDetails;
            this.hostName = hostName;
            this.location = location;
            this.title = title;
        }

        public int getID() { return  id; }
        public string getTitle() { return title; }
        public string getEventDetails() { return eventDetails; }
        public string getHostName() {  return hostName; }
        public string getLocation() { return location; }
        public void setTitle(string title) { this.title = title; }
        public void setEventDetails(string eventDetails) { this.eventDetails = eventDetails; }
        public void setHostName(string hostName) {  this.hostName = hostName; }
        public void setLocation(string location) {  this.location = location; }
        public void setID(int id) { this.id = id;}

    }
}
