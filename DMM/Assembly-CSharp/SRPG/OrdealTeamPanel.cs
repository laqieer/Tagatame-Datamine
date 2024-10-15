// Decompiled with JetBrains decompiler
// Type: SRPG.OrdealTeamPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027C7")]
  [AddComponentMenu("UI/OrdealTeamPanel")]
  public class OrdealTeamPanel : MonoBehaviour
  {
    [Token(Token = "0x400BC76")]
    [FieldOffset(Offset = "0xC")]
    public GameObject UnitSlotContainer;
    [Token(Token = "0x400BC77")]
    [FieldOffset(Offset = "0x10")]
    public OrdealUnitSlot[] UnitSlots;
    [Token(Token = "0x400BC78")]
    [FieldOffset(Offset = "0x14")]
    public OrdealUnitSlot SupportSlot;
    [Token(Token = "0x400BC79")]
    [FieldOffset(Offset = "0x18")]
    [FormerlySerializedAs("TotalAtk")]
    public Text TotalCombatPower;
    [Token(Token = "0x400BC7A")]
    [FieldOffset(Offset = "0x1C")]
    public Text TeamName;
    [Token(Token = "0x400BC7B")]
    [FieldOffset(Offset = "0x20")]
    public Button Button;
    [Token(Token = "0x400BC7C")]
    [FieldOffset(Offset = "0x24")]
    private int mUnitCount;

    [Token(Token = "0x600B2CE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B2CF")]
    [Address(RVA = "0x7AE3B0", Offset = "0x7AD1B0", VA = "0x107AE3B0")]
    private void Reset()
    {
    }

    [Token(Token = "0x600B2D0")]
    [Address(RVA = "0x7AE2E0", Offset = "0x7AD0E0", VA = "0x107AE2E0")]
    public void Add(UnitData unitData)
    {
    }

    [Token(Token = "0x600B2D1")]
    [Address(RVA = "0x7AE470", Offset = "0x7AD270", VA = "0x107AE470")]
    public void SetSupport(SupportData supportData)
    {
    }

    [Token(Token = "0x600B2D2")]
    [Address(RVA = "0x7AE4F0", Offset = "0x7AD2F0", VA = "0x107AE4F0")]
    public OrdealTeamPanel()
    {
    }
  }
}
