// Decompiled with JetBrains decompiler
// Type: SRPG.SortMenuArtifact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AF0")]
  public class SortMenuArtifact : SortMenu
  {
    [Token(Token = "0x400D185")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public Toggle ArtifactStone;
    [Token(Token = "0x400D186")]
    [FieldOffset(Offset = "0x38")]
    private bool isArtifactStone;

    [Token(Token = "0x17001A24")]
    public bool IsArtifactStone
    {
      [Token(Token = "0x600C442"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C443")]
    [Address(RVA = "0x8CD340", Offset = "0x8CC140", VA = "0x108CD340", Slot = "5")]
    public override void RestoreState()
    {
    }

    [Token(Token = "0x600C444")]
    [Address(RVA = "0x8CD3A0", Offset = "0x8CC1A0", VA = "0x108CD3A0")]
    public void SetArtifactStone(string key)
    {
    }

    [Token(Token = "0x600C445")]
    [Address(RVA = "0x8CD2F0", Offset = "0x8CC0F0", VA = "0x108CD2F0")]
    public void GetArtifactStone(string key)
    {
    }

    [Token(Token = "0x600C446")]
    [Address(RVA = "0x8CD440", Offset = "0x8CC240", VA = "0x108CD440")]
    public SortMenuArtifact()
    {
    }
  }
}
