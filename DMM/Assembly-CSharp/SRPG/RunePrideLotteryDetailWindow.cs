// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideLotteryDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A0A")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(200, "更新", FlowNode.PinTypes.Input, 200)]
  public class RunePrideLotteryDetailWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CC5F")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CC60")]
    private const int PIN_INPUT_REFRESH = 200;
    [Token(Token = "0x400CC61")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject itemTemplate;
    [Token(Token = "0x400CC62")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform trParent;
    [Token(Token = "0x400CC63")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400CC64")]
    [FieldOffset(Offset = "0x18")]
    private List<RunePrideLotteryDetailParameterModel> models;
    [Token(Token = "0x400CC65")]
    [FieldOffset(Offset = "0x1C")]
    private List<GameObject> itemList;

    [Token(Token = "0x600BFA7")]
    [Address(RVA = "0x8808A0", Offset = "0x87F6A0", VA = "0x108808A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BFA8")]
    [Address(RVA = "0x8808C0", Offset = "0x87F6C0", VA = "0x108808C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600BFA9")]
    [Address(RVA = "0x880D20", Offset = "0x87FB20", VA = "0x10880D20")]
    public void Initialize(string potentialStatusIname)
    {
    }

    [Token(Token = "0x600BFAA")]
    [Address(RVA = "0x880910", Offset = "0x87F710", VA = "0x10880910")]
    private void CreateParameteres()
    {
    }

    [Token(Token = "0x600BFAB")]
    [Address(RVA = "0x881040", Offset = "0x87FE40", VA = "0x10881040")]
    public RunePrideLotteryDetailWindow()
    {
    }
  }
}
