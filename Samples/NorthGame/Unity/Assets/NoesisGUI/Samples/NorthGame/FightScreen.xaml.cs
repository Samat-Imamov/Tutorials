﻿#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System.Windows.Controls;
#endif

namespace NorthGame
{
    /// <summary>
    /// Interaction logic for FightScreen.xaml
    /// </summary>
    public partial class FightScreen : UserControl
    {
        public FightScreen()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            Noesis.GUI.LoadComponent(this, "Assets/NoesisGUI/Samples/NorthGame/FightScreen.xaml");
        }
#endif
    }
}
