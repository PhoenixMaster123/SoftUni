package barracksWars.core.commands;

import barracksWars.interfaces.CommandInterpreter;
import barracksWars.interfaces.Executable;
import barracksWars.interfaces.Repository;
import barracksWars.interfaces.UnitFactory;

import java.lang.reflect.Constructor;
import java.lang.reflect.InvocationTargetException;

public class CommandInterpreterImpl implements CommandInterpreter {

    private static final String COMMAND_PACKAGE = "barracksWars.core.commands.";
    private Repository repository;
    private UnitFactory unitFactory;

    public CommandInterpreterImpl(Repository repository, UnitFactory unitFactory) {
        this.repository = repository;
        this.unitFactory = unitFactory;
    }
    @Override
    public Executable interpretCommand(String[] data, String commandName) throws ClassNotFoundException, NoSuchMethodException, InvocationTargetException, InstantiationException, IllegalAccessException {
        String className = COMMAND_PACKAGE + Character.toUpperCase(commandName.charAt(0)) + commandName.substring(1) + "Command";
        Class<Command> commandClass = (Class<Command>) Class.forName(className);
        Constructor<Command> constructor = commandClass.getDeclaredConstructor(String[].class, Repository.class, UnitFactory.class);
        constructor.setAccessible(true);
        Command command = constructor.newInstance(data, repository, unitFactory);
        return command;
    }
}
