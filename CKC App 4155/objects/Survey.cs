﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKC_App_4155.Objects
{
    public class Survey : ObservableObject
    {
        public int id;
        public int numChoices;
        public string title;
        public string Title {
            get
            {
                return this.title;
            }
            set
            {
                SetProperty(ref title, value);

            }
        }
        public string a, b, c, d, e, f = "";
        public int countA, countB, countC, countD, countE, countF = 0;
        public Survey() { }
        public Survey(int id, int numChoice, string title, string choice_a, string choice_b, string choice_c, string choice_d, string choice_e, string choice_f)
        {
            this.id = id;
            this.numChoices = numChoice;
            this.title = title;
            this.a = choice_a;
            this.b = choice_b;
            this.c = choice_c;
            this.d = choice_d;
            this.e = choice_e;
            this.f = choice_f;
        }
        public int getId() { return id; }
        public int getNumChoices() { return numChoices;}
        public string getTitle() { return title; }
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
        public void setId(int id) { this.id = id; }
        public void setNumChoices(int num) { this.numChoices = num; }
        public void setTitle(string title) {  this.title = title; }
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
