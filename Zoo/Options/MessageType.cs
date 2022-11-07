using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Options
{
    public enum MessageType
    {
        AddAnimalFailure,
        AddAnimalSuccess,
        AnimalFeed,
        AnimalRemove,
        AnimalRemoveException
    }
}
