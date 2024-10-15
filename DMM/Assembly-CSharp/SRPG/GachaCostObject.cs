// Decompiled with JetBrains decompiler
// Type: SRPG.GachaCostObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200244B")]
  public class GachaCostObject : MonoBehaviour
  {
    [Token(Token = "0x400A4CC")]
    [FieldOffset(Offset = "0xC")]
    private GameObject m_root;
    [Token(Token = "0x400A4CD")]
    [FieldOffset(Offset = "0x10")]
    private GameObject m_ticket;
    [Token(Token = "0x400A4CE")]
    [FieldOffset(Offset = "0x14")]
    private GameObject m_default;
    [Token(Token = "0x400A4CF")]
    [FieldOffset(Offset = "0x18")]
    private GameObject m_default_bg;
    [Token(Token = "0x400A4D0")]
    [FieldOffset(Offset = "0x1C")]
    private GameObject m_cost_item;
    [Token(Token = "0x400A4D1")]
    [FieldOffset(Offset = "0x20")]
    private Text m_cost_item_num;
    [Token(Token = "0x400A4D2")]
    [FieldOffset(Offset = "0x24")]
    private Transform m_CostNum;
    [Token(Token = "0x400A4D3")]
    [FieldOffset(Offset = "0x28")]
    private Transform m_CostFree;

    [Token(Token = "0x17001627")]
    public GameObject RootObject
    {
      [Token(Token = "0x6009E76"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6009E77"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x17001628")]
    public GameObject TicketObject
    {
      [Token(Token = "0x6009E78"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6009E79"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x17001629")]
    public GameObject DefaultObject
    {
      [Token(Token = "0x6009E7A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6009E7B"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x1700162A")]
    public GameObject DefaultBGObject
    {
      [Token(Token = "0x6009E7C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6009E7D"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x1700162B")]
    public GameObject CostItemObject
    {
      [Token(Token = "0x6009E7E"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6009E7F"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700162C")]
    public Text CostItemNum
    {
      [Token(Token = "0x6009E80"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (Text) null;
      }
      [Token(Token = "0x6009E81"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x6009E82")]
    [Address(RVA = "0x608A20", Offset = "0x607820", VA = "0x10608A20")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009E83")]
    [Address(RVA = "0x608A30", Offset = "0x607830", VA = "0x10608A30")]
    private void UpdateCostData()
    {
    }

    [Token(Token = "0x6009E84")]
    [Address(RVA = "0x6085F0", Offset = "0x6073F0", VA = "0x106085F0")]
    private bool RefreshCostNum(GameObject _root, bool needComma, int _cost = 0) => new bool();

    [Token(Token = "0x6009E85")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaCostObject()
    {
    }
  }
}
