// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetSerializeCompressMethod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001625")]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Network/SetSerializeCompressMethod", 32741)]
  public class FlowNode_SetSerializeCompressMethod : FlowNode
  {
    [Token(Token = "0x400503F")]
    private const int PINID_IN = 0;
    [Token(Token = "0x4005040")]
    private const int PINID_OUT = 1;
    [Token(Token = "0x4005041")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EncodingTypes.ESerializeCompressMethod Method;
    [Token(Token = "0x4005042")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool SetMethod;
    [Token(Token = "0x4005043")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    private bool UnsetMethod;
    [Token(Token = "0x4005044")]
    [FieldOffset(Offset = "0x1E")]
    [SerializeField]
    private bool EncryptionOn;
    [Token(Token = "0x4005045")]
    [FieldOffset(Offset = "0x1F")]
    [SerializeField]
    private bool EncryptionOff;
    [Token(Token = "0x4005046")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool MsgPackMDOn;
    [Token(Token = "0x4005047")]
    [FieldOffset(Offset = "0x21")]
    [SerializeField]
    private bool MsgPackMDOff;

    [Token(Token = "0x6005B07")]
    [Address(RVA = "0x12FBD80", Offset = "0x12FAB80", VA = "0x112FBD80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B08")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetSerializeCompressMethod()
    {
    }
  }
}
