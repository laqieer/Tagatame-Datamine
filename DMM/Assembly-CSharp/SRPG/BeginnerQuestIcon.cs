// Decompiled with JetBrains decompiler
// Type: SRPG.BeginnerQuestIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002088")]
  [AddComponentMenu("UI/BeginnerQuestIcon")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  public class BeginnerQuestIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008C2A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool ShowOnlyBeginnerPeriod;
    [Token(Token = "0x4008C2B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject Badge;
    [Token(Token = "0x4008C2C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Emmision;

    [Token(Token = "0x6008765")]
    [Address(RVA = "0x48C530", Offset = "0x48B330", VA = "0x1048C530", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008766")]
    [Address(RVA = "0x48C550", Offset = "0x48B350", VA = "0x1048C550")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008767")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BeginnerQuestIcon()
    {
    }
  }
}
