// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001458")]
  [FlowNode.NodeType("System/PlayerPrefs/Utility", 16729156)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_PlayerPrefs : FlowNode
  {
    [Token(Token = "0x4004B3C")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_PlayerPrefs.Type mType;
    [Token(Token = "0x4004B3D")]
    [FieldOffset(Offset = "0x1C")]
    public string mName;
    [Token(Token = "0x4004B3E")]
    [FieldOffset(Offset = "0x20")]
    public bool mIsSave;
    [Token(Token = "0x4004B3F")]
    [FieldOffset(Offset = "0x24")]
    public int mIntParam;
    [Token(Token = "0x4004B40")]
    [FieldOffset(Offset = "0x28")]
    public float mFloatParam;
    [Token(Token = "0x4004B41")]
    [FieldOffset(Offset = "0x2C")]
    public string mStringParam;

    [Token(Token = "0x6005526")]
    [Address(RVA = "0x1298F20", Offset = "0x1297D20", VA = "0x11298F20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005527")]
    [Address(RVA = "0x1296EE0", Offset = "0x1295CE0", VA = "0x11296EE0")]
    public FlowNode_PlayerPrefs()
    {
    }

    [Token(Token = "0x2001459")]
    public enum Type
    {
      [Token(Token = "0x4004B43")] Delete,
      [Token(Token = "0x4004B44")] Int,
      [Token(Token = "0x4004B45")] Float,
      [Token(Token = "0x4004B46")] String,
    }
  }
}
