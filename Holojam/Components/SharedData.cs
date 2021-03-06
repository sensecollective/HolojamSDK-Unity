// SharedData.cs
// Created by Holojam Inc. on 08.11.17

using UnityEngine;

namespace Holojam.Components {

  public class SharedData : Network.Controller {

    [SerializeField] string label = "MySharedData";

    public void SetLabel(string label) {
      this.label = label;
    }

    public override string Label {
      get { return label; }
    }

    public override string Scope {
      get { return ""; }
    }

    public override bool Sending {
      get { return Tools.BuildManager.IsMasterClient(); }
    }
  }
}
