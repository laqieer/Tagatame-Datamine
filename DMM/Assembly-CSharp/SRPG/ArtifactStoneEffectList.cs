// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactStoneEffectList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FED")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class ArtifactStoneEffectList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087AA")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x40087AB")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x40087AC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x40087AD")]
    [FieldOffset(Offset = "0x10")]
    private List<ArtifactStoneEffectModel> mModels;

    [Token(Token = "0x60083BF")]
    [Address(RVA = "0x45A340", Offset = "0x459140", VA = "0x1045A340", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083C0")]
    [Address(RVA = "0x45A360", Offset = "0x459160", VA = "0x1045A360")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60083C1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactStoneEffectList()
    {
    }
  }
}
