// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidHomeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D66")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidHomeButton")]
  public class WorldRaidHomeButton : MonoBehaviour
  {
    [Token(Token = "0x400E256")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BannerUnderObj;
    [Token(Token = "0x400E257")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TextObj;
    [Token(Token = "0x400E258")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ChallengeObj;
    [Token(Token = "0x400E259")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject OutPeriodObj;
    [Token(Token = "0x400E25A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool IsDirect;
    [Token(Token = "0x400E25B")]
    [FieldOffset(Offset = "0x1D")]
    private bool mTextUpdateFlag;

    [Token(Token = "0x600D391")]
    [Address(RVA = "0x9E6260", Offset = "0x9E5060", VA = "0x109E6260")]
    private void Start()
    {
    }

    [Token(Token = "0x600D392")]
    [Address(RVA = "0x9E64C0", Offset = "0x9E52C0", VA = "0x109E64C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D393")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidHomeButton()
    {
    }
  }
}
