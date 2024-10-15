// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DeletePrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013BB")]
  [FlowNode.NodeType("System/PlayerPrefs/DeletePrefs", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_DeletePrefs : FlowNode
  {
    [Token(Token = "0x40048F3")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_DeletePrefs.PrefsType Type;

    [Token(Token = "0x6005289")]
    [Address(RVA = "0x1274150", Offset = "0x1272F50", VA = "0x11274150", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600528A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_DeletePrefs()
    {
    }

    [Token(Token = "0x20013BC")]
    public enum PrefsType : byte
    {
      [Token(Token = "0x40048F5")] None,
      [Token(Token = "0x40048F6")] PlayerPrefs,
      [Token(Token = "0x40048F7")] UserInfoManager,
      [Token(Token = "0x40048F8")] All,
    }
  }
}
