// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraParamLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D1D")]
  [AddComponentMenu("UI/UnitTobiraParamLevel")]
  public class UnitTobiraParamLevel : MonoBehaviour
  {
    [Token(Token = "0x400E0AA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject OnGO;
    [Token(Token = "0x400E0AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject OffGO;
    [Token(Token = "0x400E0AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject UpGO;
    [Token(Token = "0x400E0AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int OwnLevel;

    [Token(Token = "0x600D223")]
    [Address(RVA = "0x9D2150", Offset = "0x9D0F50", VA = "0x109D2150")]
    public void Refresh(int targetLevel)
    {
    }

    [Token(Token = "0x600D224")]
    [Address(RVA = "0x9D2020", Offset = "0x9D0E20", VA = "0x109D2020")]
    public void LevelUp(int targetLevel, int upLevel)
    {
    }

    [Token(Token = "0x600D225")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitTobiraParamLevel()
    {
    }
  }
}
