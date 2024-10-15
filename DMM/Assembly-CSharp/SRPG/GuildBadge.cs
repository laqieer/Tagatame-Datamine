// Decompiled with JetBrains decompiler
// Type: SRPG.GuildBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200254C")]
  [AddComponentMenu("UI/GuildBadge")]
  public class GuildBadge : MonoBehaviour
  {
    [Token(Token = "0x400AB63")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mBadge;
    [Token(Token = "0x400AB64")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mBadgeLeague;
    [Token(Token = "0x400AB65")]
    [FieldOffset(Offset = "0x14")]
    private int mGuildLeagueRate;
    [Token(Token = "0x400AB66")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsIconDisp;

    [Token(Token = "0x600A4B4")]
    [Address(RVA = "0x66BCA0", Offset = "0x66AAA0", VA = "0x1066BCA0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A4B5")]
    [Address(RVA = "0x66BD30", Offset = "0x66AB30", VA = "0x1066BD30")]
    private void Update()
    {
    }

    [Token(Token = "0x600A4B6")]
    [Address(RVA = "0x66BA10", Offset = "0x66A810", VA = "0x1066BA10")]
    private bool IsBadgeActive() => new bool();

    [Token(Token = "0x600A4B7")]
    [Address(RVA = "0x66BBD0", Offset = "0x66A9D0", VA = "0x1066BBD0")]
    private bool IsUpdate() => new bool();

    [Token(Token = "0x600A4B8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildBadge()
    {
    }
  }
}
