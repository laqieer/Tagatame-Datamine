// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidPartyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002587")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidPartyList")]
  public class GuildRaidPartyList : MonoBehaviour
  {
    [Token(Token = "0x400ADF2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenericSlot UnitSlotTemplate;
    [Token(Token = "0x400ADF3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform MainMemberHolder;
    [Token(Token = "0x400ADF4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform SubMemberHolder;
    [Token(Token = "0x400ADF5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GenericSlot CardSlotTemplate;
    [Token(Token = "0x400ADF6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform MainMemberCardHolder;
    [Token(Token = "0x400ADF7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform SubMemberCardHolder;

    [Token(Token = "0x600A6C3")]
    [Address(RVA = "0x687550", Offset = "0x686350", VA = "0x10687550")]
    public void Setup(List<UnitData> party)
    {
    }

    [Token(Token = "0x600A6C4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRaidPartyList()
    {
    }
  }
}
