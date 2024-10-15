// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DrawCardStartUpWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001348")]
  [FlowNode.NodeType("DrawCard/DrawCardStartUpWindow", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_DrawCardStartUpWindow : FlowNode_GUI
  {
    [Token(Token = "0x4004767")]
    private const string PREFAB_DEFAULT_PATH = "UI/DrawCard/DrawCardEventWindow";
    [Token(Token = "0x4004768")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private List<string> DrawCardPrefabPathList;

    [Token(Token = "0x6005116")]
    [Address(RVA = "0x124F5D0", Offset = "0x124E3D0", VA = "0x1124F5D0", Slot = "17")]
    protected override void OnCreatePinActive()
    {
    }

    [Token(Token = "0x6005117")]
    [Address(RVA = "0x124F6A0", Offset = "0x124E4A0", VA = "0x1124F6A0")]
    public FlowNode_DrawCardStartUpWindow()
    {
    }
  }
}
