using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_17714;

//Napomena: Svi algoritmi, osim multithreaded-TEA, učitavaju i obrađuju
//blok po blok nekog fajla preko buffera, tako da je izbegnuto neželjeno
//učitavanje velikih fajlova u memoriju.
public interface ICryptoAlgorithm
{
    void EncryptFile(Stream fileInputStream, Stream fileOutputStream);
    void DecryptFile(Stream fileInputStream, Stream fileOutputStream);
}
