// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactWindowEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200204D")]
  [AddComponentMenu("UI/ArtifactWindowEventHandler")]
  public class ArtifactWindowEventHandler : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4008ADF")]
    [FieldOffset(Offset = "0xC")]
    public ArtifactList mArtifactList;
    [Token(Token = "0x4008AE0")]
    [FieldOffset(Offset = "0x10")]
    public ArtifactScrollList mArtifactScrollList;
    [Token(Token = "0x4008AE1")]
    [FieldOffset(Offset = "0x14")]
    public Button mBackButton;
    [Token(Token = "0x4008AE2")]
    [FieldOffset(Offset = "0x18")]
    public Button mForwardButton;

    [Token(Token = "0x600862E")]
    [Address(RVA = "0x4798F0", Offset = "0x4786F0", VA = "0x104798F0")]
    public void OnBackButton(Button button)
    {
    }

    [Token(Token = "0x600862F")]
    [Address(RVA = "0x479A10", Offset = "0x478810", VA = "0x10479A10")]
    public void OnForwardButton(Button button)
    {
    }

    [Token(Token = "0x6008630")]
    [Address(RVA = "0x4798B0", Offset = "0x4786B0", VA = "0x104798B0")]
    public ArtifactData GetArtifactData() => (ArtifactData) null;

    [Token(Token = "0x6008631")]
    [Address(RVA = "0x479DF0", Offset = "0x478BF0", VA = "0x10479DF0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6008632")]
    [Address(RVA = "0x479B30", Offset = "0x478930", VA = "0x10479B30")]
    private void UpdateBackButtonIntaractable()
    {
    }

    [Token(Token = "0x6008633")]
    [Address(RVA = "0x479C90", Offset = "0x478A90", VA = "0x10479C90")]
    private void UpdateForwardButtonIntaractable()
    {
    }

    [Token(Token = "0x6008634")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactWindowEventHandler()
    {
    }
  }
}
