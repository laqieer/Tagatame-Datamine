// Decompiled with JetBrains decompiler
// Type: SRPG.RaidArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028C8")]
  [AddComponentMenu("UI/Raid/RaidArea")]
  public class RaidArea : MonoBehaviour
  {
    [Token(Token = "0x400C381")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RaidAreaListAssets mRaidAreaList;
    [Token(Token = "0x400C382")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mStageRaidIcon;
    [Token(Token = "0x400C383")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mStageRaidBossIcon;
    [Token(Token = "0x400C384")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRaidAreaTitleText;
    [Token(Token = "0x400C385")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mRaidAreaBGParent;
    [Token(Token = "0x400C386")]
    [FieldOffset(Offset = "0x20")]
    private List<RaidBossIcon> mRaidBossIconList;
    [Token(Token = "0x400C387")]
    [FieldOffset(Offset = "0x24")]
    private RaidStagePoint mRaidStagePoint;
    [Token(Token = "0x400C388")]
    [FieldOffset(Offset = "0x28")]
    private LoadRequest mResourceRequest;
    [Token(Token = "0x400C389")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mRaidAreaBG;
    [Token(Token = "0x400C38A")]
    [FieldOffset(Offset = "0x30")]
    private bool mFinishDownload;
    [Token(Token = "0x400C38B")]
    [FieldOffset(Offset = "0x31")]
    private bool mIsAreaCleared;
    [Token(Token = "0x400C38C")]
    [FieldOffset(Offset = "0x32")]
    private bool mSelectingRandomRaid;

    [Token(Token = "0x1700192E")]
    public bool FinishDownload
    {
      [Token(Token = "0x600B85D"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700192F")]
    public bool IsAreaCleared
    {
      [Token(Token = "0x600B85E"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B85F")]
    [Address(RVA = "0x7F49B0", Offset = "0x7F37B0", VA = "0x107F49B0")]
    public void FinishSelectingRandomRaid()
    {
    }

    [Token(Token = "0x600B860")]
    [Address(RVA = "0x7F49C0", Offset = "0x7F37C0", VA = "0x107F49C0")]
    public void Initialize(int areaIndex = -1)
    {
    }

    [Token(Token = "0x600B861")]
    [Address(RVA = "0x7F54C0", Offset = "0x7F42C0", VA = "0x107F54C0")]
    public void StartSelectRaid()
    {
    }

    [Token(Token = "0x600B862")]
    [Address(RVA = "0x7F5530", Offset = "0x7F4330", VA = "0x107F5530")]
    private IEnumerator _StartSelectRaid() => (IEnumerator) null;

    [Token(Token = "0x600B863")]
    [Address(RVA = "0x7F4940", Offset = "0x7F3740", VA = "0x107F4940")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600B864")]
    [Address(RVA = "0x7F48D0", Offset = "0x7F36D0", VA = "0x107F48D0")]
    private IEnumerator DownloadBGImage() => (IEnumerator) null;

    [Token(Token = "0x600B865")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidArea()
    {
    }
  }
}
