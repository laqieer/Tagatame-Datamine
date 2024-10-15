// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisStarRewardWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024FE")]
  [AddComponentMenu("UI/Genesis/GenesisStarRewardWindow")]
  public class GenesisStarRewardWindow : MonoBehaviour
  {
    [Token(Token = "0x400A90A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mBodyText;
    [Token(Token = "0x400A90B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mRewardIconParent;
    [Token(Token = "0x400A90C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GenesisRewardIcon mRewardIconTemplate;
    [Token(Token = "0x400A90D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mReceiveButton;
    [Token(Token = "0x400A90E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mButtonText;

    [Token(Token = "0x600A278")]
    [Address(RVA = "0x649200", Offset = "0x648000", VA = "0x10649200")]
    private void Start()
    {
    }

    [Token(Token = "0x600A279")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisStarRewardWindow()
    {
    }
  }
}
