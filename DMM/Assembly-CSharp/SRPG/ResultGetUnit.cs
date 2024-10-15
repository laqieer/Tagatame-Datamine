// Decompiled with JetBrains decompiler
// Type: SRPG.ResultGetUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C64")]
  [AddComponentMenu("Battle/BattleUI/ResultGetUnit")]
  public class ResultGetUnit : MonoBehaviour
  {
    [Token(Token = "0x4002165")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GoGetUnitAnim;
    [Token(Token = "0x4002166")]
    [FieldOffset(Offset = "0x10")]
    public GameObject GoGetUnitDetail;
    [Token(Token = "0x4002167")]
    [FieldOffset(Offset = "0x14")]
    public RawImage ImgUnit;

    [Token(Token = "0x60030DA")]
    [Address(RVA = "0x10232C0", Offset = "0x10220C0", VA = "0x110232C0")]
    private void Start()
    {
    }

    [Token(Token = "0x60030DB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ResultGetUnit()
    {
    }
  }
}
