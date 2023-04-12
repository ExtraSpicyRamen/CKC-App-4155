using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKC_App_4155.Objects
{
    public class Survey
    {
        public int Id;
        public string Title;
        public string a, b, c, d, e, f = "";
        public int countA, countB, countC, countD, countE, countF;
        public Survey() { } 
        public Survey(int id, string title, string choice_a, string choice_b, string choice_c, string choice_d, string choice_e, string choice_f)
        {
            this.Id = id;
            this.Title = title;
            this.a = choice_a;
            this.b = choice_b;
            this.c = choice_c;
            this.d = choice_d;
            this.e = choice_e;
            this.f = choice_f;
        }
        public int getId() { return Id; }
        public string getTitle() { return Title; }
        public string getA() { return a; }
        public string getB() { return b; }
        public string getC() { return c; }
        public string getD() { return d; }
        public string getE() { return e; }
        public string getF() { return f; }
        public int getCountA() { return countA; }
        public int getCountB() { return countB; }
        public int getCountC() { return countC; }
        public int getCountD() { return countD; }
        public int getCountE() { return countE; }
        public int getCountF() { return countF; }
        public void setId(int id) { this.Id = id; }
        public void setTitle(string title) {  this.Title = title; }
        public void setA(string a) {  this.a = a; }
        public void setB(string b) {  this.b = b; }
        public void setC(string c) {  this.c = c; }
        public void setD(string d) {  this.d = d; }
        public void setE(string e) {  this.e = e; }
        public void setF(string f) {  this.f = f; }
        public void setCountA(int countA) { this.countA = countA; }
        public void setCountB(int countB) { this.countB = countB; }
        public void setCountC(int countC) { this.countC = countC; }
        public void setCountD(int countD) { this.countD = countD; }
        public void setCountE(int countE) { this.countE = countE; }
        public void setCountF(int countF) { this.countF = countF; }
    }
}
