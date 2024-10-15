// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckVersion2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001392")]
  [FlowNode.Pin(12, "Reset to Title", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(1000, "No Version", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1001, "Different Assets", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(11, "Success Offline", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Start Online", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Version/CheckVersion2", 32741)]
  [FlowNode.Pin(10, "Success Online", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_CheckVersion2 : FlowNode_Network
  {
    [Token(Token = "0x600520C")]
    [Address(RVA = "0x126E120", Offset = "0x126CF20", VA = "0x1126E120", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600520D")]
    [Address(RVA = "0x126E050", Offset = "0x126CE50", VA = "0x1126E050")]
    public void CheckVersionResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600520E")]
    [Address(RVA = "0x126E270", Offset = "0x126D070", VA = "0x1126E270", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600520F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_CheckVersion2()
    {
    }

    [Token(Token = "0x2001393")]
    private class Json_Alchemist
    {
      [Token(Token = "0x4004854")]
      [FieldOffset(Offset = "0x8")]
      public string assets;
      [Token(Token = "0x4004855")]
      [FieldOffset(Offset = "0xC")]
      public string assets_ex;
      [Token(Token = "0x4004856")]
      [FieldOffset(Offset = "0x10")]
      public int use_appguard;
      [Token(Token = "0x4004857")]
      [FieldOffset(Offset = "0x14")]
      public string master_digest;
      [Token(Token = "0x4004858")]
      [FieldOffset(Offset = "0x18")]
      public string quest_digest;
      [Token(Token = "0x4004859")]
      [FieldOffset(Offset = "0x1C")]
      public int env_flg;
      [Token(Token = "0x400485A")]
      [FieldOffset(Offset = "0x20")]
      public string env_flg2;

      [Token(Token = "0x6005210")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Alchemist()
      {
      }
    }

    [Token(Token = "0x2001394")]
    private class Json_Environment
    {
      [Token(Token = "0x400485B")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_CheckVersion2.Json_Alchemist alchemist;

      [Token(Token = "0x6005211")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Environment()
      {
      }
    }

    [Token(Token = "0x2001395")]
    private class Json_VersionInfo
    {
      [Token(Token = "0x400485C")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_CheckVersion2.Json_Environment environments;

      [Token(Token = "0x6005212")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_VersionInfo()
      {
      }
    }
  }
}
