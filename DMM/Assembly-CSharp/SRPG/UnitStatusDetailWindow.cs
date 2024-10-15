// Decompiled with JetBrains decompiler
// Type: SRPG.UnitStatusDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C3C")]
  [AddComponentMenu("UI/UnitInventory/UnitStatusDetailWindow")]
  public class UnitStatusDetailWindow : MonoBehaviour
  {
    [Token(Token = "0x400DB03")]
    public const string SVB_KEY_UNIT_DATA = "unit_data";
    [Token(Token = "0x400DB04")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<UnitStatusDetailCategory> m_Categories;
    [Token(Token = "0x400DB05")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour m_SerializeValue;

    [Token(Token = "0x600CCE4")]
    [Address(RVA = "0x98E620", Offset = "0x98D420", VA = "0x1098E620")]
    private void Start()
    {
    }

    [Token(Token = "0x600CCE5")]
    [Address(RVA = "0x98E4F0", Offset = "0x98D2F0", VA = "0x1098E4F0")]
    private void RefreshStatus(UnitData unit)
    {
    }

    [Token(Token = "0x600CCE6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitStatusDetailWindow()
    {
    }
  }
}
