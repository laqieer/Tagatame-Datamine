// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_DownloadAssets
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013BF")]
  [FlowNode.Pin(100, "キャンセル", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(1, "確認", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "ダウンロード完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "ダウンロード開始", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "ダウンロード", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/アセットのダウンロード", 16711935)]
  [FlowNode.Pin(99, "エラー発生", FlowNode.PinTypes.Output, 99)]
  public class FlowNode_DownloadAssets : FlowNode
  {
    [Token(Token = "0x40048FA")]
    [FieldOffset(Offset = "0x18")]
    public bool UpdateFileList;
    [Token(Token = "0x40048FB")]
    [FieldOffset(Offset = "0x1C")]
    public string[] AssetPaths;
    [Token(Token = "0x40048FC")]
    [FieldOffset(Offset = "0x20")]
    public string[] DownloadQuests;
    [Token(Token = "0x40048FD")]
    [FieldOffset(Offset = "0x24")]
    public string[] DownloadUnits;
    [Token(Token = "0x40048FE")]
    [FieldOffset(Offset = "0x28")]
    [BitMask]
    public FlowNode_DownloadAssets.DownloadAssets Download;
    [Token(Token = "0x40048FF")]
    [FieldOffset(Offset = "0x2C")]
    public string ConfirmText;
    [Token(Token = "0x4004900")]
    [FieldOffset(Offset = "0x30")]
    public string AlreadyDownloadText;
    [Token(Token = "0x4004901")]
    [FieldOffset(Offset = "0x34")]
    public string CompleteText;
    [Token(Token = "0x4004902")]
    [FieldOffset(Offset = "0x38")]
    public bool ProgressBar;
    [Token(Token = "0x4004903")]
    [FieldOffset(Offset = "0x39")]
    public bool SkipIfTutIncomplete;
    [Token(Token = "0x4004904")]
    [FieldOffset(Offset = "0x3A")]
    public bool AutoRetry;
    [Token(Token = "0x4004905")]
    [FieldOffset(Offset = "0x3C")]
    private List<AssetList.Item> mQueue;
    [Token(Token = "0x4004906")]
    private const string MANAGED_BGM_ASSET_PATH = "StreamingAssets/";
    [Token(Token = "0x4004907")]
    private const string UNMANAGED_BGM_ASSET_PATH = "sound/";

    [Token(Token = "0x6005290")]
    [Address(RVA = "0x1275110", Offset = "0x1273F10", VA = "0x11275110", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005291")]
    [Address(RVA = "0x1275270", Offset = "0x1274070", VA = "0x11275270")]
    private void OnDownloadStart(GameObject dialog)
    {
    }

    [Token(Token = "0x6005292")]
    [Address(RVA = "0x1275240", Offset = "0x1274040", VA = "0x11275240")]
    private void OnDownloadCancel(GameObject dialog)
    {
    }

    [Token(Token = "0x6005293")]
    [Address(RVA = "0x12750A0", Offset = "0x1273EA0", VA = "0x112750A0")]
    private IEnumerator AsyncWork(bool confirm, bool allDownload) => (IEnumerator) null;

    [Token(Token = "0x6005294")]
    [Address(RVA = "0x1274E90", Offset = "0x1273C90", VA = "0x11274E90")]
    private IEnumerator AddAssets() => (IEnumerator) null;

    [Token(Token = "0x6005295")]
    [Address(RVA = "0x1274E00", Offset = "0x1273C00", VA = "0x11274E00")]
    public static void AddAssets_Towns()
    {
    }

    [Token(Token = "0x6005296")]
    [Address(RVA = "0x1274410", Offset = "0x1273210", VA = "0x11274410")]
    public static void AddAssets_All_PlayableUnits()
    {
    }

    [Token(Token = "0x6005297")]
    [Address(RVA = "0x12742E0", Offset = "0x12730E0", VA = "0x112742E0")]
    public static void AddAssets_All_Artifacts()
    {
    }

    [Token(Token = "0x6005298")]
    [Address(RVA = "0x1274380", Offset = "0x1273180", VA = "0x11274380")]
    public static void AddAssets_All_ConceptCards()
    {
    }

    [Token(Token = "0x6005299")]
    [Address(RVA = "0x12744A0", Offset = "0x12732A0", VA = "0x112744A0")]
    private IEnumerator AddAssets_ChallengableAllSectionQuests() => (IEnumerator) null;

    [Token(Token = "0x600529A")]
    [Address(RVA = "0x1274C40", Offset = "0x1273A40", VA = "0x11274C40")]
    public static void AddAssets_Home_Raid()
    {
    }

    [Token(Token = "0x600529B")]
    [Address(RVA = "0x1274D00", Offset = "0x1273B00", VA = "0x11274D00")]
    public static void AddAssets_Home_Tower()
    {
    }

    [Token(Token = "0x600529C")]
    [Address(RVA = "0x1274BE0", Offset = "0x12739E0", VA = "0x11274BE0")]
    private IEnumerator AddAssets_Home_MultiTower() => (IEnumerator) null;

    [Token(Token = "0x600529D")]
    [Address(RVA = "0x1274B80", Offset = "0x1273980", VA = "0x11274B80")]
    private IEnumerator AddAssets_Home_MultiPlay() => (IEnumerator) null;

    [Token(Token = "0x600529E")]
    [Address(RVA = "0x1274EF0", Offset = "0x1273CF0", VA = "0x11274EF0")]
    public static void AddUnManagedAssets_All()
    {
    }

    [Token(Token = "0x600529F")]
    [Address(RVA = "0x12746C0", Offset = "0x12734C0", VA = "0x112746C0")]
    public static void AddAssets_Home_GuildRaid()
    {
    }

    [Token(Token = "0x60052A0")]
    [Address(RVA = "0x1274500", Offset = "0x1273300", VA = "0x11274500")]
    public static void AddAssets_History_GuildRaid()
    {
    }

    [Token(Token = "0x60052A1")]
    [Address(RVA = "0x12747D0", Offset = "0x12735D0", VA = "0x112747D0")]
    public static void AddAssets_Home_JukeBox()
    {
    }

    [Token(Token = "0x60052A2")]
    [Address(RVA = "0x1274610", Offset = "0x1273410", VA = "0x11274610")]
    public static void AddAssets_Home_AutoRepeatQuest()
    {
    }

    [Token(Token = "0x60052A3")]
    [Address(RVA = "0x1274D80", Offset = "0x1273B80", VA = "0x11274D80")]
    public static void AddAssets_Home_WorldRaid()
    {
    }

    [Token(Token = "0x60052A4")]
    [Address(RVA = "0x1275300", Offset = "0x1274100", VA = "0x11275300")]
    public FlowNode_DownloadAssets()
    {
    }

    [Token(Token = "0x20013C0")]
    [Flags]
    public enum DownloadAssets
    {
      [Token(Token = "0x4004909")] Tutorial = 1,
      [Token(Token = "0x400490A")] OwnUnits = 2,
      [Token(Token = "0x400490B")] AllUnits = 4,
      [Token(Token = "0x400490C")] ItemIcons = 8,
      [Token(Token = "0x400490D")] Multiplay = 16, // 0x00000010
      [Token(Token = "0x400490E")] Artifacts = 32, // 0x00000020
      [Token(Token = "0x400490F")] LoginBonus = 64, // 0x00000040
      [Token(Token = "0x4004910")] OwnConceptCard = 128, // 0x00000080
      [Token(Token = "0x4004911")] SkinConceptCard = 256, // 0x00000100
      [Token(Token = "0x4004912")] Town = 512, // 0x00000200
      [Token(Token = "0x4004913")] iOSRequire = 1024, // 0x00000400
      [Token(Token = "0x4004914")] All_PlayableUnits = 2048, // 0x00000800
      [Token(Token = "0x4004915")] All_Artifacts = 4096, // 0x00001000
      [Token(Token = "0x4004916")] All_ConceptCards = 8192, // 0x00002000
      [Token(Token = "0x4004917")] ChallengableAllSectionQuests = 16384, // 0x00004000
      [Token(Token = "0x4004918")] Home_Raid = 32768, // 0x00008000
      [Token(Token = "0x4004919")] Home_Tower = 65536, // 0x00010000
      [Token(Token = "0x400491A")] Home_MultiTower = 131072, // 0x00020000
      [Token(Token = "0x400491B")] Home_MultiPlay = 262144, // 0x00040000
      [Token(Token = "0x400491C")] All_UnManagedAssets = 524288, // 0x00080000
      [Token(Token = "0x400491D")] Home_GuildRaid = 1048576, // 0x00100000
      [Token(Token = "0x400491E")] History_GuildRaid = 2097152, // 0x00200000
      [Token(Token = "0x400491F")] HomeAssets = 4194304, // 0x00400000
      [Token(Token = "0x4004920")] Home_JukeBox = 8388608, // 0x00800000
      [Token(Token = "0x4004921")] Home_AutoRepeatQuest = 16777216, // 0x01000000
      [Token(Token = "0x4004922")] Home_WorldRaid = 33554432, // 0x02000000
    }
  }
}
