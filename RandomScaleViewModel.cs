// Copyright © 2021 Waters Corporation. All Rights Reserved.

using System;
using System.Collections.Generic;
using ReactiveUI;

namespace RandomScale
{
    public class RandomScaleViewModel : ReactiveObject
    {
        private readonly List<string> Grade3Options = new()
        {
            "B♭ major\nstarting an octave above lowest tonic\n(1 octave)",
            "D major\n(a 12th)",
            "G major\n(a 12th)",
            "C major\n(2 octave)",
            "B minor\nstarting an octave above lowest tonic\n(1 octave)",
            "E minor\n(a 12th)",
            "G minor\n(a 12th)",
            "Chromatic scale starting on G\n(1 octave)",
            "B♭ major arpeggio\nstarting an octave above lowest tonic\n(1 octave)",
            "D major arpeggio\n(a 12th)",
            "G major arpeggio\n(a 12th)",
            "C major arpeggio\n(2 octave)",
            "B minor arpeggio\nstarting an octave above lowest tonic\n(1 octave)",
            "E minor arpeggio\n(a 12th)",
            "G minor arpeggio\n(a 12th)"
        };

        private string chosenScale;
        private readonly Random random = new();

        public string ChosenScale
        {
            get => chosenScale;
            private set => this.RaiseAndSetIfChanged(ref this.chosenScale, value);
        }

        public RandomScaleViewModel()
        {
            ChosenScale = Grade3Options[random.Next() % Grade3Options.Count];
        }

        public void ChooseAgain()
        {
            ChosenScale = Grade3Options[random.Next() % Grade3Options.Count];
        }
    }
}