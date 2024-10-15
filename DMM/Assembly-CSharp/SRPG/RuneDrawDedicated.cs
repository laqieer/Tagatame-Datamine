// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawDedicated
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002970")]
  public class RuneDrawDedicated : MonoBehaviour
  {
    [Token(Token = "0x400C7BC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform ParentObject;
    [Token(Token = "0x400C7BD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject DedicatedOn;
    [Token(Token = "0x400C7BE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text DedicatedCondtionsText;
    [Token(Token = "0x400C7BF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Color DedicatedMatchTextColor;
    [Token(Token = "0x400C7C0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Color DedicatedUnMatchTextColor;
    [Token(Token = "0x400C7C1")]
    [FieldOffset(Offset = "0x38")]
    private BindRuneData _runeData;
    [Token(Token = "0x400C7C2")]
    [FieldOffset(Offset = "0x40")]
    private long _selectedUnitID;

    [Token(Token = "0x600BB86")]
    [Address(RVA = "0x83D340", Offset = "0x83C140", VA = "0x1083D340")]
    public void SetDrawParam(BindRuneData runeData, long selectedUnitID)
    {
    }

    [Token(Token = "0x600BB87")]
    [Address(RVA = "0x83CDD0", Offset = "0x83BBD0", VA = "0x1083CDD0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BB88")]
    [Address(RVA = "0x834810", Offset = "0x833610", VA = "0x10834810")]
    public RuneDrawDedicated()
    {
    }
  }
}
