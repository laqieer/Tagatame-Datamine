// Decompiled with JetBrains decompiler
// Type: SRPG.GvGBattleResultUnitContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200259C")]
  [AddComponentMenu("UI/GvG/GvGBattleResultUnitContent")]
  public class GvGBattleResultUnitContent : MonoBehaviour
  {
    [Token(Token = "0x400AE72")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider mGauge;
    [Token(Token = "0x400AE73")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mDead;

    [Token(Token = "0x600A709")]
    [Address(RVA = "0x68DE30", Offset = "0x68CC30", VA = "0x1068DE30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A70A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGBattleResultUnitContent()
    {
    }
  }
}
