﻿using System;
using System.Windows;
using System.Windows.Forms;
using Rhino;
using Rhino.Commands;
using MessageBox = System.Windows.MessageBox;

namespace CodeListener
{
    [System.Runtime.InteropServices.Guid("56773c6e-b5d1-462f-af01-43bed492ef53")]
    public class CodeListenerVersion : Command
    {
        static CodeListenerVersion _instance;
        public CodeListenerVersion()
        {
            _instance = this;
        }

        ///<summary>The only instance of the CodeListenerVersion command.</summary>
        public static CodeListenerVersion Instance
        {
            get { return _instance; }
        }

        public override string EnglishName
        {
            get { return "CodeListenerVersion"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            // TODO: remember to change to versions every time publish a new one!!
            RhinoApp.WriteLine("CodeListener Version: 0.1.4");
            return Result.Success;
        }

    }
}
