using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using ToolsImage.Structures;
using GEDParticulier.Segmentation;

namespace GEDParticulier.Process
{
    public abstract class absProcessusOCR
    {
        #region Segmentation
        /// <summary>
        /// CCL 
        /// RLSA
        /// Détection lignes, mots, caractères
        /// accents, caractères spéciaux
        /// Possibilités de types de caractères
        /// Majuscules, minuscules, minuscules ascendance base et haute
        /// Si montants , caractères . ou ,
        /// </summary>
        /// <param name="img"></param>
        /// <param name="source_rect"></param>
        /// <param name="imgCROP"></param>
        /// <returns></returns>
        public Dictionary<string, Structure> Segmentation(Bitmap img, Rectangle source_rect, ref Bitmap imgCROP)
        {
            try
            {
                return null;
            }
            catch(Exception err)
            {
                return null;
            }
        }
        #endregion 
        
        #region préparation 
        /// <summary>
        /// Normalisation du caractère
        /// </summary>
        /// <param name="imgCROP"></param>
        /// <param name="structure"></param>
        /// <param name="varX"></param>
        /// <param name="varY"></param>
        /// <param name="varHauteur"></param>
        /// <param name="varLargeur"></param>
        /// <param name="bordure"></param>
        /// <param name="NewBitmap"></param>
        /// <returns></returns>
        private byte[] Preparation(Bitmap imgCROP, Structure structure, int varX, int varY, int varHauteur, int varLargeur, int bordure, ref Bitmap NewBitmap)
        {
            try
            {
                return null;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        #endregion 
       
        #region performOCR
        /// <summary>
        /// Classification sur les différents fichiers de parametrage 
        /// Pour l'instant majuscules, minuscules et chiffres imprimes 
        /// Chiffres manuscrits
        /// </summary>
        /// <param name="dicFinal"></param>
        /// <param name="imgCROP"></param>
        /// <returns></returns>
     
        public Dictionary<string, Structure> performOCR(Dictionary<string, Structure> dicFinal, Bitmap imgCROP)
        {
            try
            {
                return null;

            }
            catch (Exception err)
            {
                return null;
            }
        }
        #endregion 
        /// <summary>
        /// Filtre les résultats suivants les besoins 
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="typeReso"></param>
        /// <returns></returns>
        public Dictionary<string, Structure> FiltreCaractere(Dictionary<string, Structure> temp,int typeReso)
        {
            try
            {
                return null;

            }
            catch (Exception err)
            {
                return null;
            }
        }
        /// <summary>
        /// Decoupe Dictionary<string, Structure> en mots 
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="numeroMot"></param>
        /// <returns></returns>
        public Dictionary<string, Structure> ListeMots(Dictionary<string, Structure> temp, int numeroMot)
        {
            try
            {
                return null;

            }
            catch (Exception err)
            {
                return null;
            }
        }
        /// <summary>
        /// Retourne une table de table de caractères 
        /// Exemple: {{D},{a,A},{t,l},{e}}
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public List<List<Char>> TableauCaracteres(Dictionary<string, Structure> temp)
        {
            try
            {
                return null;

            }
            catch (Exception err)
            {
                return null;
            }
        }
        /// <summary>
        /// Pattern possible pour les lettres
        /// Mmmm MMMM mmmm 
        /// Majuscules au début et minuscules après 
        /// tout majuscules ou minuscules
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public List<Mot> ValidationPattern(List<string> words)
        {
            try
            {
                return null;

            }
            catch (Exception err)
            {
                return null;
            }
        }
        /// <summary>
        /// Validation les résultats des moteurs OCR
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public String ValidationMoteurOCR(List<string> words)
        {
            try
            {
                return null;

            }
            catch (Exception err)
            {
                return null;
            }
        }
		
		/// <summary>
        /// Retourne vrai ou faux si trouve dans le dictionnaire donné en paramêtre
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public Boolean VerificationDictionnaire(Dico dicoGeneral,String mot)
        {
            try
            {
                return true;

            }
            catch (Exception err)
            {
                return false;
            }
        }
        /// <summary>
        /// Retourne la chaine la plus proche 
        /// Algo de Levingstein
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public String CorrectionDictionnaire(Dico dicoGeneral,String mot)
        {
            try
            {
                return "";

            }
            catch (Exception err)
            {
                return "";
            }
        }

        // Récupération de la zone 
        public abstract String RecuperationZone(Dictionary<string, Structure> temp, int numero);
      
        // Validation d'une valeur 
        // différent, peut être date, siret, montant 
        public abstract String Validation(String valeur, String pattern);
      
    }
}
