﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Denik.DQEmulation.Entity
{
    [CreateAssetMenu(fileName = nameof(PlayerData), menuName = "DQEmulation/" + nameof(PlayerData))]
    public class PlayerData : ScriptableObject
    {
        [SerializeField]
        private List<PlayerEntity> _playerEntities;

        public List<PlayerEntity> PlayerEntities => _playerEntities;
    }

    [Serializable]
    public class PlayerEntity
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private Sprite _figure;
        [SerializeField]
        private float _maxHitPoint;
        // MP のデータを追加しよう
        [SerializeField]
        private float _maxMagicPoint;
        [SerializeField]
        private float attackPower;
        [SerializeField]
        private float _healPower;

        public string Name => _name;
        public Sprite Figure => _figure;
        public float MaxHitPoint => _maxHitPoint;
        // MP のデータを取得するgetterを追加しよう
        public float MaxMagicPoint => _maxMagicPoint;
        public float AttackPower => attackPower;
        public float HealPower => _healPower;
    }
}