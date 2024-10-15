// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ResumeTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015F4")]
  [FlowNode.Pin(2, "Start Quest", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(10, "DebugEndMovieLoad", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1, "Next Step", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(50, "TutorialSkipStart", FlowNode.PinTypes.Input, 50)]
  [FlowNode.NodeType("Tutorial/ResumeTutorial")]
  [FlowNode.Pin(3, "Resume Quest", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(0, "Try", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(4, "Tutorial Skipped", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(5, "Resume Tower", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(6, "Resume Multi", FlowNode.PinTypes.Output, 6)]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "ResumeNormalQuest Cancel", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(21, "ResumeMultiTower Cancel", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(20, "ClearResumeMultiTower", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(19, "Resume MultiTower", FlowNode.PinTypes.Output, 19)]
  [FlowNode.Pin(18, "FgGChainWish", FlowNode.PinTypes.Output, 18)]
  [FlowNode.Pin(17, "GotoHome", FlowNode.PinTypes.Input, 17)]
  [FlowNode.Pin(16, "ClearResumeVersus", FlowNode.PinTypes.Input, 16)]
  [FlowNode.Pin(15, "Resume Versus Cancel", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(14, "Resume Versus", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(13, "Resume Multi Cancel", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "ClearTutorial", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "DebugMovieLoad", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(8, "ResumeTowerError", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(7, "ClearResumeMulti", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(51, "TutorialSkipFinish", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(1000, "Download Cancel", FlowNode.PinTypes.Output, 1000)]
  public class FlowNode_ResumeTutorial : FlowNode
  {
    [Token(Token = "0x4004FA9")]
    private const int PIN_IN_TUTORIAL_SKIP = 50;
    [Token(Token = "0x4004FAA")]
    private const int PIN_IN_TUTORIAL_SKIP_FINISH = 51;
    [Token(Token = "0x4004FAB")]
    private const string SKIP_TUTORIAL_SCENE = "op0005exit";
    [Token(Token = "0x4004FAC")]
    [FieldOffset(Offset = "0x18")]
    private bool mSkipTutorial;

    [Token(Token = "0x6005A2C")]
    [Address(RVA = "0x12ECF10", Offset = "0x12EBD10", VA = "0x112ECF10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A2D")]
    [Address(RVA = "0x12EE650", Offset = "0x12ED450", VA = "0x112EE650")]
    private void OnResumeAccept(GameObject go)
    {
    }

    [Token(Token = "0x6005A2E")]
    [Address(RVA = "0x12EE6C0", Offset = "0x12ED4C0", VA = "0x112EE6C0")]
    private void OnTowerResumeAccept(GameObject go)
    {
    }

    [Token(Token = "0x6005A2F")]
    [Address(RVA = "0x126A4D0", Offset = "0x12692D0", VA = "0x1126A4D0")]
    private void OnMultiResumeAccept(GameObject go)
    {
    }

    [Token(Token = "0x6005A30")]
    [Address(RVA = "0x12EE700", Offset = "0x12ED500", VA = "0x112EE700")]
    private void OnVersusAccept(GameObject go)
    {
    }

    [Token(Token = "0x6005A31")]
    [Address(RVA = "0x12EE610", Offset = "0x12ED410", VA = "0x112EE610")]
    private void OnMultiTowerAccept(GameObject go)
    {
    }

    [Token(Token = "0x6005A32")]
    [Address(RVA = "0x12EE670", Offset = "0x12ED470", VA = "0x112EE670")]
    private void OnResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A33")]
    [Address(RVA = "0x12EE6E0", Offset = "0x12ED4E0", VA = "0x112EE6E0")]
    private void OnTowerResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A34")]
    [Address(RVA = "0x12EE5F0", Offset = "0x12ED3F0", VA = "0x112EE5F0")]
    private void OnMultiResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A35")]
    [Address(RVA = "0x12EE720", Offset = "0x12ED520", VA = "0x112EE720")]
    private void OnVersusResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A36")]
    [Address(RVA = "0x12EE630", Offset = "0x12ED430", VA = "0x112EE630")]
    private void OnMultiTowerResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A37")]
    [Address(RVA = "0x12EC450", Offset = "0x12EB250", VA = "0x112EC450")]
    private void OnRaidResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A38")]
    [Address(RVA = "0x12EBC60", Offset = "0x12EAA60", VA = "0x112EBC60")]
    private void OnGenesisBossResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A39")]
    [Address(RVA = "0x12EB980", Offset = "0x12EA780", VA = "0x112EB980")]
    private void OnAdvanceBossResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A3A")]
    [Address(RVA = "0x12EE5D0", Offset = "0x12ED3D0", VA = "0x112EE5D0")]
    private void OnGuildRaidResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A3B")]
    [Address(RVA = "0x12EBFE0", Offset = "0x12EADE0", VA = "0x112EBFE0")]
    private void OnGuildRaidTrailResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A3C")]
    [Address(RVA = "0x12ECA60", Offset = "0x12EB860", VA = "0x112ECA60")]
    private void OnWorldRaidResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A3D")]
    [Address(RVA = "0x12EBAF0", Offset = "0x12EA8F0", VA = "0x112EBAF0")]
    private void OnDuelResumeCancel(GameObject go)
    {
    }

    [Token(Token = "0x6005A3E")]
    [Address(RVA = "0x12EE860", Offset = "0x12ED660", VA = "0x112EE860")]
    private void SetDefaultResumeConfirm(UIUtility.DialogResultEvent result = null)
    {
    }

    [Token(Token = "0x6005A3F")]
    [Address(RVA = "0x1275FD0", Offset = "0x1274DD0", VA = "0x11275FD0")]
    private void OnPlayTutorial(GameObject go)
    {
    }

    [Token(Token = "0x6005A40")]
    [Address(RVA = "0x12EE690", Offset = "0x12ED490", VA = "0x112EE690")]
    private void OnSkipTutorial(GameObject go)
    {
    }

    [Token(Token = "0x6005A41")]
    [Address(RVA = "0x12EE910", Offset = "0x12ED710", VA = "0x112EE910")]
    private void StartTutorialSkip()
    {
    }

    [Token(Token = "0x6005A42")]
    [Address(RVA = "0x12EE740", Offset = "0x12ED540", VA = "0x112EE740")]
    private void PlayTutorial()
    {
    }

    [Token(Token = "0x6005A43")]
    [Address(RVA = "0x12ECBE0", Offset = "0x12EB9E0", VA = "0x112ECBE0")]
    private void CompleteTutorial(bool is_from_tutorial_skip = false)
    {
    }

    [Token(Token = "0x6005A44")]
    [Address(RVA = "0x12EE9A0", Offset = "0x12ED7A0", VA = "0x112EE9A0")]
    private IEnumerator WaitCompleteTutorialAsync(bool is_from_tutorial_skip = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6005A45")]
    [Address(RVA = "0x12EC5D0", Offset = "0x12EB3D0", VA = "0x112EC5D0")]
    private void ClearResumeData(bool is_rehash = false)
    {
    }

    [Token(Token = "0x6005A46")]
    [Address(RVA = "0x12EC760", Offset = "0x12EB560", VA = "0x112EC760")]
    private void ClearTowerResumeData()
    {
    }

    [Token(Token = "0x6005A47")]
    [Address(RVA = "0x12EC150", Offset = "0x12EAF50", VA = "0x112EC150")]
    private void ClearMultiResumeData()
    {
    }

    [Token(Token = "0x6005A48")]
    [Address(RVA = "0x12EC8D0", Offset = "0x12EB6D0", VA = "0x112EC8D0")]
    private void ClearVersusResumeData()
    {
    }

    [Token(Token = "0x6005A49")]
    [Address(RVA = "0x12EC2E0", Offset = "0x12EB0E0", VA = "0x112EC2E0")]
    private void ClearMultiTowerResumeData()
    {
    }

    [Token(Token = "0x6005A4A")]
    [Address(RVA = "0x12EC450", Offset = "0x12EB250", VA = "0x112EC450")]
    private void ClearRaidResumeData()
    {
    }

    [Token(Token = "0x6005A4B")]
    [Address(RVA = "0x12EBC60", Offset = "0x12EAA60", VA = "0x112EBC60")]
    private void ClearGenesisBossResumeData()
    {
    }

    [Token(Token = "0x6005A4C")]
    [Address(RVA = "0x12EB980", Offset = "0x12EA780", VA = "0x112EB980")]
    private void ClearAdvanceBossResumeData()
    {
    }

    [Token(Token = "0x6005A4D")]
    [Address(RVA = "0x12EBDD0", Offset = "0x12EABD0", VA = "0x112EBDD0")]
    private void ClearGuildRaidResumeData()
    {
    }

    [Token(Token = "0x6005A4E")]
    [Address(RVA = "0x12EBFE0", Offset = "0x12EADE0", VA = "0x112EBFE0")]
    private void ClearGuildRaidTrailResumeData()
    {
    }

    [Token(Token = "0x6005A4F")]
    [Address(RVA = "0x12ECA60", Offset = "0x12EB860", VA = "0x112ECA60")]
    private void ClearWorldRaidResumeData()
    {
    }

    [Token(Token = "0x6005A50")]
    [Address(RVA = "0x12EBAF0", Offset = "0x12EA8F0", VA = "0x112EBAF0")]
    private void ClearDuelResumeData()
    {
    }

    [Token(Token = "0x6005A51")]
    [Address(RVA = "0x12EDFD0", Offset = "0x12ECDD0", VA = "0x112EDFD0")]
    private void OnBtlComEnd(WWWResult www)
    {
    }

    [Token(Token = "0x6005A52")]
    [Address(RVA = "0x12ECDD0", Offset = "0x12EBBD0", VA = "0x112ECDD0")]
    private void LoadStartScene(bool fromTutorial = false)
    {
    }

    [Token(Token = "0x6005A53")]
    [Address(RVA = "0x12ECCF0", Offset = "0x12EBAF0", VA = "0x112ECCF0")]
    private IEnumerator DownloadContentAsync(string sceneName) => (IEnumerator) null;

    [Token(Token = "0x6005A54")]
    [Address(RVA = "0x12ECCC0", Offset = "0x12EBAC0", VA = "0x112ECCC0")]
    private void DownloadApproved(string sceneName)
    {
    }

    [Token(Token = "0x6005A55")]
    [Address(RVA = "0x128E6F0", Offset = "0x128D4F0", VA = "0x1128E6F0")]
    private void DownloadNotApproved()
    {
    }

    [Token(Token = "0x6005A56")]
    [Address(RVA = "0x12ECD60", Offset = "0x12EBB60", VA = "0x112ECD60")]
    private IEnumerator LoadSceneAsync(string sceneName) => (IEnumerator) null;

    [Token(Token = "0x6005A57")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ResumeTutorial()
    {
    }
  }
}
