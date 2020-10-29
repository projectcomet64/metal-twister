using M64MM.Additions;
using METALTwister.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace METALTwister
{

    public class Module : IModule
    {
        AngleBlaster bform;

        public string SafeName => "Twister";

        public string Description => "Spin animations and enable Free Roam";

        public Image AddonIcon => Resources.twister_512;

        public void Close(EventArgs e)
        {
             
        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> returned = new List<ToolCommand>();
            ToolCommand appear = new ToolCommand("Open Twister");
            appear.Summoned += (a, b) => ShowForm();
            returned.Add(appear);
            return returned;
        }

        public void Initialize()
        {
         if (bform == null)
            {
                bform = new AngleBlaster();
            }    
        }

        void ShowForm()
        {
            if (bform == null)
            {
                Initialize();
            }
            else
            {
                bform.Show();
            }
        }

        public void OnBaseAddressFound()
        {
        }

        public void OnBaseAddressZero()
        {
        }

        public void OnCoreEntAddressChange(uint addr)
        {
        }

        public void Reset()
        {
        }

        public void Update()
        {
            if (bform != null)
            {
                if (bform.AutoEnabled)
                {
                    bform.AddAngle();
                }
                bform.ForceFreeRoam();
            }
        }
    }
}
