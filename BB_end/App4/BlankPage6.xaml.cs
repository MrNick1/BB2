using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// Шаблон элемента пустой страницы задокументирован по адресу http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BlankPage6 : Page
    {
        int i_max1=3;
        int i_max2=2;
        int i_max3=1;
        int i_max4 = 2;

        int i_gel;


        int[,] newvar1=new int[4,5];
        int[,] newvar2=new int[4,5];
        int[,] newvar3=new int[4,5];
        int[,] newvar4 = new int[4, 5];

        int color = 0;

        int[,] endb = new int[4, 5];
        int j_max1=1;
        int j_max2=2;
        int j_max3=3;
        int j_max4 = 1;
        
        public BlankPage6()
        {
            this.InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    newvar1[i, j] = 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <5; j++)
                {
                    newvar2[i, j] = 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    newvar3[i, j] = 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    newvar4[i, j] = 0;
                }
            }
                newvar1[0, 0] = 1;
            newvar1[1,0]=1;
            newvar1[2,0]=1;
            newvar1[3,0]=1;
            newvar1[1,1]=1;

            newvar2[0, 0] = 2;
            newvar2[0, 1] = 2;
            newvar2[0, 2] = 2;
            newvar2[1, 1] = 2;
            newvar2[2, 1] = 2;

            newvar3[0,0]=3;
            newvar3[1,0]=3;
            newvar3[1,1]=3;
            newvar3[1,2]=3;
            newvar3[1,3]=3;

            newvar4[0,1]=4;
            newvar4[1,0]=4;
            newvar4[1,1]=4;
            newvar4[2,0]=4;
            newvar4[2,1]=4;
            color = 1;
            if (newvar1[0, 0] == 1) { b00s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 1] == 1) { b01s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 2] == 1) { b02s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 3] == 1) { b03s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 4] == 1) { b04s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            

            if (newvar1[1, 0] == 1) { b10s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 1] == 1) { b11s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 2] == 1) { b12s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 3] == 1) { b13s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 4] == 1) { b14s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
           

            if (newvar1[2, 0] == 1) { b20s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 1] == 1) { b21s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 2] == 1) { b22s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 3] == 1) { b23s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 4] == 1) { b24s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
           
            if (newvar1[3, 0] == 1) { b30s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 1] == 1) { b31s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 2] == 1) { b32s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 3] == 1) { b33s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 4] == 1) { b34s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            

           
        }

        private void obut_Click(object sender, RoutedEventArgs e)
        {
            color = 1;

            clean();

            if (newvar1[0, 0] == 1) { b00s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 1] == 1) { b01s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 2] == 1) { b02s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 3] == 1) { b03s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[0, 4] == 1) { b04s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            

            if (newvar1[1, 0] == 1) { b10s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 1] == 1) { b11s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 2] == 1) { b12s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 3] == 1) { b13s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[1, 4] == 1) { b14s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            

            if (newvar1[2, 0] == 1) { b20s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 1] == 1) { b21s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 2] == 1) { b22s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 3] == 1) { b23s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[2, 4] == 1) { b24s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            

            if (newvar1[3, 0] == 1) { b30s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 1] == 1) { b31s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 2] == 1) { b32s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 3] == 1) { b33s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
            if (newvar1[3, 4] == 1) { b34s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
           

            
        }

        private void rbut_Click(object sender, RoutedEventArgs e)
        {
            color = 2;

            clean();

            if (newvar2[0, 0] == 2) { b00s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[0, 1] == 2) { b01s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[0, 2] == 2) { b02s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[0, 3] == 2) { b03s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[0, 4] == 2) { b04s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
         

            if (newvar2[1, 0] == 2) { b10s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[1, 1] == 2) { b11s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[1, 2] == 2) { b12s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[1, 3] == 2) { b13s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[1, 4] == 2) { b14s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            

            if (newvar2[2, 0] == 2) { b20s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[2, 1] == 2) { b21s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[2, 2] == 2) { b22s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[2, 3] == 2) { b23s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[2, 4] == 2) { b24s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            

            if (newvar2[3, 0] == 2) { b30s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[3, 1] == 2) { b31s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[3, 2] == 2) { b32s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[3, 3] == 2) { b33s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (newvar2[3, 4] == 2) { b34s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
          
        
        }

        private void gbut_Click(object sender, RoutedEventArgs e)
        {
            color = 3;

            clean();

            if (newvar3[0, 0] == 3) { b00s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[0, 1] == 3) { b01s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[0, 2] == 3) { b02s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[0, 3] == 3) { b03s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[0, 4] == 3) { b04s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
        

            if (newvar3[1, 0] == 3) { b10s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[1, 1] == 3) { b11s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[1, 2] == 3) { b12s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[1, 3] == 3) { b13s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[1, 4] == 3) { b14s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            

            if (newvar3[2, 0] == 3) { b20s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[2, 1] == 3) { b21s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[2, 2] == 3) { b22s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[2, 3] == 3) { b23s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[2, 4] == 3) { b24s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
        

            if (newvar3[3, 0] == 3) { b30s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[3, 1] == 3) { b31s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[3, 2] == 3) { b32s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[3, 3] == 3) { b33s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            if (newvar3[3, 4] == 3) { b34s.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
            
        
        }

        private void ybut_Click(object sender, RoutedEventArgs e)
        {
            color = 4;

            clean();

            if (newvar4[0, 0] == 4) { b00s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[0, 1] == 4) { b01s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[0, 2] == 4) { b02s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[0, 3] == 4) { b03s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[0, 4] == 4) { b04s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }

            if (newvar4[1, 0] == 4) { b10s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[1, 1] == 4) { b11s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[1, 2] == 4) { b12s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[1, 3] == 4) { b13s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[1, 4] == 4) { b14s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }


            if (newvar4[2, 0] == 4) { b20s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[2, 1] == 4) { b21s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[2, 2] == 4) { b22s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[2, 3] == 4) { b23s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[2, 4] == 4) { b24s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
      

            if (newvar4[3, 0] == 4) { b30s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[3, 1] == 4) { b31s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[3, 2] == 4) { b32s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[3, 3] == 4) { b33s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            if (newvar4[3, 4] == 4) { b34s.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
            

        }
        private void clean()
        {
            b00s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b01s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b02s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b03s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b04s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            b10s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b11s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b12s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b13s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b14s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            b20s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b21s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b22s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b23s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b24s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

            b30s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b31s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b32s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b33s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            b34s.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        public void gel()
        {

            int g = color;
            switch (g)
            {
                case 1:
                    int j_z = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (newvar1[i, j_z] == 1)
                        {
                            i_gel = i;
                            break;
                        }
                    }
                    break;
                case 2:
                    j_z = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (newvar2[i, j_z] == 2)
                        {
                            i_gel = i;
                            break;
                        }
                    }
                    break;
                case 3:
                    j_z = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (newvar3[i, j_z] == 3)
                        {
                            i_gel = i;
                            break;
                        }
                    }
                    break;
                case 4:
                    j_z = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (newvar4[i, j_z] == 4)
                        {
                            i_gel = i;
                            break;
                        }
                    }
                    break;
            }
        }
        public void chan(int i_selected, int j_selected)
        {
            int i_max;
            int j_max;
            i_selected = i_selected - i_gel;
            int ind = color;
            if (i_selected >= 0)
            {
                switch (ind)
                {
                    case 1:
                        i_max = i_max1;
                        j_max = j_max1;
                        //массив
                        int[,] br = new int[i_max + 1, j_max + 1];
                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                if (newvar1[i, j] == ind)
                                {
                                    br[i, j] = ind;
                                }
                                else { br[i, j] = 0; }
                            }
                        }

                        //проверка
                        bool can = true;
                        int i1 = 0;
                        int j1 = 0;
                        if ((i_max + i_selected < 4) && (j_max + j_selected < 5))
                        {
                            for (int i = i_selected; i < i_selected + i_max + 1; i++)
                            {
                                j1 = 0;
                                for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                {

                                    if ((br[i1, j1] == ind) && ((endb[i, j] == 2) || (endb[i, j] == 3) || (endb[i, j] == 4)))
                                    {
                                        can = false;
                                    }
                                    j1++;

                                }
                                i1++;
                            }


                            if (can == true)
                            {   //обнуление
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        if (endb[i, j] == ind) { endb[i, j] = 0; }
                                    }
                                }

                                i1 = 0;
                                j1 = 0;
                                for (int i = i_selected; i < i_selected + i_max + 1; i++)
                                {
                                    j1 = 0;
                                    for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                    {
                                        if (br[i1, j1] == ind)
                                        {
                                            endb[i, j] = ind;
                                        }
                                        j1++;
                                    }
                                    i1++;
                                }
                            }
                        }
                        if (endb[0, 0] == ind) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[0, 1] == ind) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[0, 2] == ind) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[0, 3] == ind) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[0, 4] == ind) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }

                        if (endb[1, 0] == ind) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[1, 1] == ind) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[1, 2] == ind) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[1, 3] == ind) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[1, 4] == ind) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }

                        if (endb[2, 0] == ind) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[2, 1] == ind) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[2, 2] == ind) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[2, 3] == ind) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[2, 4] == ind) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }

                        if (endb[3, 0] == ind) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[3, 1] == ind) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[3, 2] == ind) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[3, 3] == ind) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }
                        if (endb[3, 4] == ind) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 0)); }

                        
                        if (endb[0, 0] == 0) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 1] == 0) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 2] == 0) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 3] == 0) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 4] == 0) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[1, 0] == 0) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 1] == 0) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 2] == 0) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 3] == 0) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 4] == 0) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[2, 0] == 0) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 1] == 0) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 2] == 0) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 3] == 0) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 4] == 0) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[3, 0] == 0) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 1] == 0) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 2] == 0) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 3] == 0) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 4] == 0) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                       
                        break;

                    case 2:
                        i_max = i_max2;
                        j_max = j_max2;
                        //массив
                        br = new int[i_max + 1, j_max + 1];
                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                br[i, j] = 0;
                            }
                        }

                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                if (newvar2[i, j] == ind)
                                {
                                    br[i, j] = ind;
                                }
                                else { br[i, j] = 0; }
                            }
                        }
                        //проверка
                        can = true;
                        i1 = 0;
                        j1 = 0;
                        if ((i_max + i_selected < 4) && (j_max + j_selected < 5))
                        {
                            for (int i = i_selected; i < i_selected + i_max + 1; i++)
                            {
                                j1 = 0;
                                for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                {
                                    if ((br[i1, j1] == ind) && ((endb[i, j] == 1) || (endb[i, j] == 3) || (endb[i, j] == 4)))
                                    {
                                        can = false;
                                    }
                                    j1++;

                                }
                                i1++;
                            }

                            if (can == true)
                            {   //обнуление
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        if (endb[i, j] == ind) { endb[i, j] = 0; };
                                    }
                                }

                                i1 = 0;
                                j1 = 0;
                                for (int i = i_selected; i < i_selected + i_max + 1; i++)
                                {
                                    j1 = 0;
                                    for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                    {
                                        if (br[i1, j1] == ind)
                                        {
                                            endb[i, j] = ind;
                                        }
                                        j1++;
                                    }
                                    i1++;
                                }
                            }
                        }
                        if (endb[0, 0] == ind) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[0, 1] == ind) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[0, 2] == ind) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[0, 3] == ind) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[0, 4] == ind) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }

                        if (endb[1, 0] == ind) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[1, 1] == ind) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[1, 2] == ind) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[1, 3] == ind) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[1, 4] == ind) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }

                        if (endb[2, 0] == ind) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[2, 1] == ind) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[2, 2] == ind) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[2, 3] == ind) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[2, 4] == ind) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }

                        if (endb[3, 0] == ind) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[3, 1] == ind) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[3, 2] == ind) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[3, 3] == ind) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
                        if (endb[3, 4] == ind) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }

                        
                        if (endb[0, 0] == 0) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 1] == 0) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 2] == 0) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 3] == 0) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 4] == 0) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[1, 0] == 0) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 1] == 0) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 2] == 0) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 3] == 0) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 4] == 0) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[2, 0] == 0) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 1] == 0) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 2] == 0) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 3] == 0) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 4] == 0) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[3, 0] == 0) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 1] == 0) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 2] == 0) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 3] == 0) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 4] == 0) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        
                        break;
                    case 3:
                        i_max = i_max3;
                        j_max = j_max3;
                        //массив
                        br = new int[i_max + 1, j_max + 1];
                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                br[i, j] = 0;
                            }
                        }

                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                if (newvar3[i, j] == ind)
                                {
                                    br[i, j] = ind;
                                }
                                else { br[i, j] = 0; }
                            }
                        }
                        //проверка
                        can = true;
                        i1 = 0;
                        j1 = 0;
                        if ((i_max + i_selected < 4) && (j_max + j_selected < 5))
                        {
                            for (int i = i_selected; i < i_selected + i_max + 1; i++)
                            {
                                j1 = 0;
                                for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                {
                                    if ((br[i1, j1] == ind) && ((endb[i, j] == 1) || (endb[i, j] == 2) || (endb[i, j] == 4)))
                                    {
                                        can = false;
                                    }
                                    j1++;

                                }
                                i1++;
                            }

                            if (can == true)
                            {   //обнуление
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        if (endb[i, j] == ind) { endb[i, j] = 0; };
                                    }
                                }

                                i1 = 0;
                                j1 = 0;
                                for (int i = i_selected; i < i_selected + i_max + 1; i++)
                                {
                                    j1 = 0;
                                    for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                    {
                                        if (br[i1, j1] == ind)
                                        {
                                            endb[i, j] = ind;
                                        }
                                        j1++;
                                    }
                                    i1++;
                                }
                            }
                        }
                        if (endb[0, 0] == ind) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[0, 1] == ind) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[0, 2] == ind) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[0, 3] == ind) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[0, 4] == ind) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }

                        if (endb[1, 0] == ind) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[1, 1] == ind) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[1, 2] == ind) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[1, 3] == ind) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[1, 4] == ind) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }

                        if (endb[2, 0] == ind) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[2, 1] == ind) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[2, 2] == ind) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[2, 3] == ind) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[2, 4] == ind) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }

                        if (endb[3, 0] == ind) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[3, 1] == ind) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[3, 2] == ind) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[3, 3] == ind) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }
                        if (endb[3, 4] == ind) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 0, 205, 0)); }

                        
                       
                        if (endb[0, 0] == 0) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 1] == 0) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 2] == 0) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 3] == 0) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 4] == 0) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[1, 0] == 0) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 1] == 0) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 2] == 0) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 3] == 0) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 4] == 0) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[2, 0] == 0) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 1] == 0) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 2] == 0) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 3] == 0) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 4] == 0) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[3, 0] == 0) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 1] == 0) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 2] == 0) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 3] == 0) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 4] == 0) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        
                        break;

                    case 4:
                        i_max = i_max4;
                        j_max = j_max4;
                        //массив
                        br = new int[i_max + 1, j_max + 1];
                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                br[i, j] = 0;
                            }
                        }

                        for (int i = 0; i < i_max + 1; i++)
                        {
                            for (int j = 0; j < j_max + 1; j++)
                            {
                                if (newvar4[i, j] == ind)
                                {
                                    br[i, j] = ind;
                                }
                                else { br[i, j] = 0; }
                            }
                        }
                        //проверка
                        can = true;
                        i1 = 0;
                        j1 = 0;
                        if ((i_max + i_selected < 4) && (j_max + j_selected < 5))
                        {
                            for (int i = i_selected; i < i_selected + i_max + 1; i++)
                            {
                                j1 = 0;
                                for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                {
                                    if ((br[i1, j1] == ind) && ((endb[i, j] == 1) || (endb[i, j] == 2) || (endb[i, j] == 3)))
                                    {
                                        can = false;
                                    }
                                    j1++;

                                }
                                i1++;
                            }

                            if (can == true)
                            {   //обнуление
                                for (int i = 0; i < 4; i++)
                                {
                                    for (int j = 0; j < 5; j++)
                                    {
                                        if (endb[i, j] == ind) { endb[i, j] = 0; };
                                    }
                                }

                                i1 = 0;
                                j1 = 0;
                                for (int i = i_selected; i < i_selected + i_max + 1; i++)
                                {
                                    j1 = 0;
                                    for (int j = j_selected; j < j_selected + j_max + 1; j++)
                                    {
                                        if (br[i1, j1] == ind)
                                        {
                                            endb[i, j] = ind;
                                        }
                                        j1++;
                                    }
                                    i1++;
                                }
                            }
                        }
                        if (endb[0, 0] == ind) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[0, 1] == ind) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[0, 2] == ind) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[0, 3] == ind) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[0, 4] == ind) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }

                        if (endb[1, 0] == ind) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[1, 1] == ind) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[1, 2] == ind) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[1, 3] == ind) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[1, 4] == ind) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }

                        if (endb[2, 0] == ind) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[2, 1] == ind) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[2, 2] == ind) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[2, 3] == ind) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[2, 4] == ind) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }

                        if (endb[3, 0] == ind) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[3, 1] == ind) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[3, 2] == ind) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[3, 3] == ind) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }
                        if (endb[3, 4] == ind) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 252, 234, 22)); }

                        
                       
                        if (endb[0, 0] == 0) { b00.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 1] == 0) { b01.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 2] == 0) { b02.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 3] == 0) { b03.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[0, 4] == 0) { b04.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[1, 0] == 0) { b10.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 1] == 0) { b11.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 2] == 0) { b12.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 3] == 0) { b13.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[1, 4] == 0) { b14.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[2, 0] == 0) { b20.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 1] == 0) { b21.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 2] == 0) { b22.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 3] == 0) { b23.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[2, 4] == 0) { b24.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                        if (endb[3, 0] == 0) { b30.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 1] == 0) { b31.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 2] == 0) { b32.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 3] == 0) { b33.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }
                        if (endb[3, 4] == 0) { b34.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)); }

                
                        break;

                }
            }
        }

        private void b00_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(0, 0);
        }

        private void b01_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(0, 1);
        }

        private void b02_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(0, 2);
        }

        private void b03_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(0, 3);
        }

        private void b04_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(0, 4);
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(1, 0);
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(1, 1);
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(1, 2);
        }

        private void b13_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(1, 3);
        }

        private void b14_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(1, 4);
        }

        private void b20_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(2, 0);
        }

        private void b21_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(2, 1);
        }

        private void b22_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(2, 2);
        }

        private void b23_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(2, 3);
        }

        private void b24_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(2, 4);
        }

        private void b30_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(3, 0);
        }

        private void b31_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(3, 1);
        }

        private void b32_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(3, 2);
        }

        private void b33_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(3, 3);
        }

        private void b34_Click(object sender, RoutedEventArgs e)
        {
            gel();
            chan(3, 4);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage5));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage3));
        }

    }
}
