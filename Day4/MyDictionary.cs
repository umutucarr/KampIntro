using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class MyDictionary<C,W>
    {
        C[] characters;
        W[] words;
        public MyDictionary()
        {
            characters = new C[0];
            words = new W[0];
            
        }
        public void Add(C character,W word)
        {
            C[] tempCharacters = characters;
            W[] tempWords = words;

            words = new W[words.Length + 1];
            characters = new C[characters.Length + 1];
            for (int i = 0; i < tempCharacters.Length; i++)
            {
                characters[i] = tempCharacters[i];
            }
            characters[characters.Length - 1] = character;
            for (int i = 0; i < tempWords.Length; i++)
            {
                words[i] = tempWords[i];
            }
            words[words.Length - 1] = word;
        }
        public int Lengt
        {
            get { return words.Length; }
            
        }
        public int Lengt2
        {
            get { return characters.Length; }
        }




    }
    
}
