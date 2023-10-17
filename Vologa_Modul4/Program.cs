using System;

public class Vologa_Modul4 
{
    static void Main(string[] args)
    {
        Figiri figiri = new Figiri();
        figiri.vivod_figur();

        Producti producti = new Producti();
        producti.vivod_productov();

        Student student = new Student();
        student.vivod_Sudenta();

        Book book = new Book();
        book.vivod_book();

        Risunok risunok = new Risunok();
        risunok.vivod_risunka();
    }
}