// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LoadShopBG
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001423")]
  [FlowNode.NodeType("Shop/LoadShopBG", 32741)]
  [FlowNode.Pin(0, "Load", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Done", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_LoadShopBG : FlowNode
  {
    [Token(Token = "0x4004A85")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_LoadShopBG.PrefabType Type;
    [Token(Token = "0x4004A86")]
    [FieldOffset(Offset = "0x1C")]
    public string TypeString;
    [Token(Token = "0x4004A87")]
    [FieldOffset(Offset = "0x20")]
    public string BasePath;
    [Token(Token = "0x4004A88")]
    [FieldOffset(Offset = "0x24")]
    public Transform Parent;
    [Token(Token = "0x4004A89")]
    [FieldOffset(Offset = "0x28")]
    public bool WorldPositionStays;

    [Token(Token = "0x600541C")]
    [Address(RVA = "0x128C8B0", Offset = "0x128B6B0", VA = "0x1128C8B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600541D")]
    [Address(RVA = "0x128CB90", Offset = "0x128B990", VA = "0x1128CB90")]
    public FlowNode_LoadShopBG()
    {
    }

    [Token(Token = "0x2001424")]
    public enum PrefabType
    {
      [Token(Token = "0x4004A8B")] SectionParamBar,
      [Token(Token = "0x4004A8C")] SectionParamShop,
      [Token(Token = "0x4004A8D")] SectionParamInn,
      [Token(Token = "0x4004A8E")] DirectResourcePath,
      [Token(Token = "0x4004A8F")] SectionParamMemberName,
    }
  }
}
