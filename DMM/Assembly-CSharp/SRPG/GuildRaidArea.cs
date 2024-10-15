// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidArea
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
  [Token(Token = "0x2002567")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidArea")]
  public class GuildRaidArea : MonoBehaviour
  {
    [Token(Token = "0x400ACB7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GuildRaidAreaListAssets mGuildRaidAreaList;
    [Token(Token = "0x400ACB8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mStageGuildRaidIcon;
    [Token(Token = "0x400ACB9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mStageGuildRaidBossIcon;
    [Token(Token = "0x400ACBA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform mGuildRaidAreaBGParent;
    [Token(Token = "0x400ACBB")]
    [FieldOffset(Offset = "0x1C")]
    private List<GuildRaidBossIcon> mGuildRaidBossIconList;
    [Token(Token = "0x400ACBC")]
    [FieldOffset(Offset = "0x20")]
    private GuildRaidStagePoint mGuildRaidStagePoint;
    [Token(Token = "0x400ACBD")]
    [FieldOffset(Offset = "0x24")]
    private LoadRequest mResourceRequest;
    [Token(Token = "0x400ACBE")]
    [FieldOffset(Offset = "0x28")]
    private GameObject mGuildRaidAreaBG;
    [Token(Token = "0x400ACBF")]
    [FieldOffset(Offset = "0x2C")]
    private bool mFinishDownload;
    [Token(Token = "0x400ACC0")]
    [FieldOffset(Offset = "0x2D")]
    private bool mIsAreaCleared;

    [Token(Token = "0x17001715")]
    public bool FinishDownload
    {
      [Token(Token = "0x600A592"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001716")]
    public bool IsAreaCleared
    {
      [Token(Token = "0x600A593"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A594")]
    [Address(RVA = "0x679930", Offset = "0x678730", VA = "0x10679930")]
    public void Initialize(int roundIndex)
    {
    }

    [Token(Token = "0x600A595")]
    [Address(RVA = "0x6798C0", Offset = "0x6786C0", VA = "0x106798C0")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600A596")]
    [Address(RVA = "0x679850", Offset = "0x678650", VA = "0x10679850")]
    private IEnumerator DownloadBGImage() => (IEnumerator) null;

    [Token(Token = "0x600A597")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRaidArea()
    {
    }
  }
}
