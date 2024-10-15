// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterQuestController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200213E")]
  [FlowNode.Pin(3, "Refresh", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Start(Restore)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Start(Mission)", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Chara", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Collabo", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Chara(Restore or Mission)", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "Collabo(Restore or Mission)", FlowNode.PinTypes.Output, 13)]
  [AddComponentMenu("UI/CharacterQuestController")]
  public class CharacterQuestController : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40090BC")]
    private const int PIN_ID_START = 0;
    [Token(Token = "0x40090BD")]
    private const int PIN_ID_START_RESTORE = 1;
    [Token(Token = "0x40090BE")]
    private const int PIN_ID_START_MISSION = 2;
    [Token(Token = "0x40090BF")]
    private const int PIN_ID_REFRESH = 3;
    [Token(Token = "0x40090C0")]
    private const int PIN_ID_CHARA = 10;
    [Token(Token = "0x40090C1")]
    private const int PIN_ID_COLLABO = 11;
    [Token(Token = "0x40090C2")]
    private const int PIN_ID_CHARA_RESTORE_OR_MISSION = 12;
    [Token(Token = "0x40090C3")]
    private const int PIN_ID_COLLABO_RESTORE_OR_MISSION = 13;
    [Token(Token = "0x40090C4")]
    [FieldOffset(Offset = "0xC")]
    public string VARIABLE_KEY;
    [Token(Token = "0x40090C5")]
    [FieldOffset(Offset = "0x10")]
    public string VARIABLE_VALUE_CHARA;
    [Token(Token = "0x40090C6")]
    [FieldOffset(Offset = "0x14")]
    public string VARIABLE_VALUE_COLLABO;

    [Token(Token = "0x6008B83")]
    [Address(RVA = "0x4F6E90", Offset = "0x4F5C90", VA = "0x104F6E90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008B84")]
    [Address(RVA = "0x4F7010", Offset = "0x4F5E10", VA = "0x104F7010")]
    public CharacterQuestController()
    {
    }
  }
}
