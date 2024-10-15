// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentStatusListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B94")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  public class TruthEquipmentStatusListView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D5DC")]
    public const string SVB_KEY_TRUTHEQUIPMENT_UNITDATA = "SVB_KEY_TRUTHEQUIPMENT_UNITDATA";
    [Token(Token = "0x400D5DD")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400D5DE")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400D5DF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400D5E0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject templateItem;

    [Token(Token = "0x600C813")]
    [Address(RVA = "0x90F010", Offset = "0x90DE10", VA = "0x1090F010", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C814")]
    [Address(RVA = "0x90F070", Offset = "0x90DE70", VA = "0x1090F070")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600C815")]
    [Address(RVA = "0x90F0D0", Offset = "0x90DED0", VA = "0x1090F0D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C816")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TruthEquipmentStatusListView()
    {
    }
  }
}
