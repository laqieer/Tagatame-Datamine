// Decompiled with JetBrains decompiler
// Type: SRPG.AppealItemGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FC3")]
  [AddComponentMenu("UI/AppealItemGacha")]
  public class AppealItemGacha : AppealItemBase
  {
    [Token(Token = "0x400869D")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SPRITES_PATH;
    [Token(Token = "0x400869E")]
    [FieldOffset(Offset = "0x18")]
    private readonly string MASTER_PATH;
    [Token(Token = "0x400869F")]
    [FieldOffset(Offset = "0x1C")]
    private string[] mAppealIds;
    [Token(Token = "0x40086A0")]
    [FieldOffset(Offset = "0x20")]
    private string mAppealId;
    [Token(Token = "0x40086A1")]
    [FieldOffset(Offset = "0x24")]
    private bool IsLoaded;
    [Token(Token = "0x40086A2")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<string, Sprite> mCacheAppealSprites;
    [Token(Token = "0x40086A3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject Ballon;
    [Token(Token = "0x40086A4")]
    [FieldOffset(Offset = "0x30")]
    private bool IsNew;

    [Token(Token = "0x60082D8")]
    [Address(RVA = "0x4362C0", Offset = "0x4350C0", VA = "0x104362C0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60082D9")]
    [Address(RVA = "0x4368B0", Offset = "0x4356B0", VA = "0x104368B0", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60082DA")]
    [Address(RVA = "0x436930", Offset = "0x435730", VA = "0x10436930", Slot = "6")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60082DB")]
    [Address(RVA = "0x436340", Offset = "0x435140", VA = "0x10436340", Slot = "7")]
    protected override void Destroy()
    {
    }

    [Token(Token = "0x60082DC")]
    [Address(RVA = "0x4364D0", Offset = "0x4352D0", VA = "0x104364D0")]
    private bool LoadAppealMaster(string path) => new bool();

    [Token(Token = "0x60082DD")]
    [Address(RVA = "0x436840", Offset = "0x435640", VA = "0x10436840")]
    private IEnumerator LoadAppealResources() => (IEnumerator) null;

    [Token(Token = "0x60082DE")]
    [Address(RVA = "0x436A80", Offset = "0x435880", VA = "0x10436A80")]
    public AppealItemGacha()
    {
    }
  }
}
