using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKC_App_4155.objects
{
    class Survey
    {
        private int id;
        private string title;
        private string question;
        private string a, b, c, d, e, f = "";
        public Survey() { } 
        public Survey(int id, string title,string question, string choice_a, string choice_b, string choice_c, string choice_d, string choice_e, string choice_f)
        {
            this.id = id;
            this.title = title;
            this.question = question;
            this.a = choice_a;
            this.b = choice_b;
            this.c = choice_c;
            this.d = choice_d;
            this.e = choice_e;
            this.f = choice_f;
        }
        public int getId() { return id; }
        public string getTitle() { return title; }
        public string getQuestion() { return question; }
        public string getA() { return a; }
        public string getB() { return b; }
        public string getC() { return c; }
        public string getD() { return d; }
        public string getE() { return e; }
        public string getF() { return f; }
        public void setId(int id) { this.id = id; }
        public void setTitle(string title) {  this.title = title; }
        public void setQuestion(string question) {  this.question = question; }
        public void setA(string a) {  this.a = a; }
        public void setB(string b) {  this.b = b; }
        public void setC(string c) {  this.c = c; }
        public void setD(string d) {  this.d = d; }
        public void setE(string e) {  this.e = e; }
        public void setF(string f) {  this.f = f; }
    }
}
