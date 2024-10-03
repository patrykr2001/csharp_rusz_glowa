using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Queen : Bee, INotifyPropertyChanged
    {
        private readonly static float EGGS_PER_SHIFT = 0.45f;
        private readonly static float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        private IWorker[] _workers = new IWorker[] { };
        private float _unassignedWorkers = 0f;
        private float _eggs = 0f;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override float CostPerShift { get { return 2.15f; } }

        public string StatusReport { get; private set; }

        public Queen() : base("Królowa")
        {
            _unassignedWorkers = 3;
            AddWorker(new HoneyManufacturer());
            AddWorker(new NectarCollector());
            AddWorker(new Eggcare(this));
        }

        private void AddWorker(IWorker worker)
        {
            if (_unassignedWorkers >= 1)
            {
                _unassignedWorkers--;
                Array.Resize(ref _workers, _workers.Length + 1);
                _workers[_workers.Length - 1] = worker;
            }
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"Raport o stanie skarbca:\n{HoneyVault.StatusReport}\n" +
                $"Liczba jaj: {_eggs:0.0}\n" +
                $"Nieprzydzielone robotnice: {_unassignedWorkers:0.0}\n" +
                $"{WorkerStatus("Zbieraczka nektaru")}\n{WorkerStatus("Producentka miodu")}\n{WorkerStatus("Opiekunka jaj")}\n" +
                $"ROBOTNICE W SUMIE: {_workers.Length}";
            OnPropertyChanged("StatusReport");
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (IWorker worker in _workers)
            {
                if (worker.Job == job) count++;
            }
            return $"{job}: {count}";
        }

        protected override void DoJob()
        {
            _eggs += EGGS_PER_SHIFT;

            foreach (IWorker worker in _workers)
            {
                worker.WorkNextShift();
            }

            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * _unassignedWorkers);
            UpdateStatusReport();
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Zbieraczka nektaru":
                    AddWorker(new NectarCollector());
                    break;
                case "Producentka miodu":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "Opiekunka jaj":
                    AddWorker(new Eggcare(this));
                    break;
                case "Obrońca roju":
                    AddWorker(new HiveDefender());
                    break;
                default:
                    break;
            }
            UpdateStatusReport() ;
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (_eggs >= eggsToConvert)
            {
                _eggs -= eggsToConvert;
                _unassignedWorkers += eggsToConvert;
            }
        }

        public void HiveUnderAttack()
        {
            foreach (IWorker worker in _workers)
            {
                //if(EnemyHive.AttackingBees > 0)
                if (true)
                {
                    if (worker is IDefender workerDefender)
                    {
                        workerDefender.DefendHive();
                    }
                }
            }
        }
    }
}
