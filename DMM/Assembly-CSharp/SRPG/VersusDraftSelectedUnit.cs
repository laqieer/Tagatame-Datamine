// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftSelectedUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002741")]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftSelectedUnit")]
  public class VersusDraftSelectedUnit : MonoBehaviour
  {
    [Token(Token = "0x400B931")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private UnitIcon mUnitIcon;
    [Token(Token = "0x400B932")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mSelecting;
    [Token(Token = "0x400B933")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mSecretIcon;
    [Token(Token = "0x400B934")]
    [FieldOffset(Offset = "0x18")]
    private DataSource mDataSource;

    [Token(Token = "0x600B007")]
    [Address(RVA = "0x743090", Offset = "0x741E90", VA = "0x10743090")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600B008")]
    [Address(RVA = "0x7431F0", Offset = "0x741FF0", VA = "0x107431F0")]
    public void Selecting()
    {
    }

    [Token(Token = "0x600B009")]
    [Address(RVA = "0x743260", Offset = "0x742060", VA = "0x10743260")]
    public void SetUnit(UnitData unit)
    {
    }

    [Token(Token = "0x600B00A")]
    [Address(RVA = "0x743170", Offset = "0x741F70", VA = "0x10743170")]
    public void Select(UnitData unit)
    {
    }

    [Token(Token = "0x600B00B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftSelectedUnit()
    {
    }
  }
}
