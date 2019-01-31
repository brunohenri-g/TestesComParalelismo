using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParellelForm
{
    public class Tarefa
    {
        #region Campos
        public CancellationTokenSource cTokenSource;
        public CancellationToken cToken;
        #endregion

        #region Construtores
        public Tarefa()
        {
            cTokenSource = new CancellationTokenSource();
            cToken = cTokenSource.Token;
        }

        public Tarefa(string nome) : this()
        {
            Descricao = nome;
        }
        #endregion

        #region Propriedades
        public string Descricao { get; set; }
        public QueueDelegate Delegate { get; set; } 
        public TarefaStatus Status { get; set; } 
        #endregion


        public Task Invoke()
        {
            return Delegate.Invoke(cToken);
        }
    }

    public enum TarefaStatus
    {
        FINALIZADA,
        NAO_INICIADA,
        CANCELADA,
        EM_PROCESSAMENTO
    }
}
